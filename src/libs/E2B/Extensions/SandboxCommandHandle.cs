namespace E2B;

/// <summary>
/// Handle for a command running in an E2B sandbox.
/// </summary>
public sealed class SandboxCommandHandle : IAsyncDisposable
{
    private readonly SandboxCommandsClient commands;
    private readonly SandboxCommandExecution execution;

    internal SandboxCommandHandle(
        int processId,
        SandboxCommandsClient commands,
        SandboxCommandExecution execution)
    {
        ProcessId = processId;
        this.commands = commands;
        this.execution = execution;
    }

    /// <summary>
    /// Process ID assigned by the sandbox.
    /// </summary>
    public int ProcessId { get; }

    /// <summary>
    /// Standard output received so far.
    /// </summary>
    public string Stdout => execution.Stdout.Text;

    /// <summary>
    /// Standard error received so far.
    /// </summary>
    public string Stderr => execution.Stderr.Text;

    /// <summary>
    /// Exit code when the command has completed; otherwise <see langword="null"/>.
    /// </summary>
    public int? ExitCode => execution.Completion.IsCompletedSuccessfully
        ? execution.Completion.Result.ExitCode
        : null;

    /// <summary>
    /// Command error when the command has completed; otherwise <see langword="null"/>.
    /// </summary>
    public string? Error => execution.Completion.IsCompletedSuccessfully
        ? execution.Completion.Result.Error
        : null;

    /// <summary>
    /// Waits for the command to finish and returns its result.
    /// </summary>
    /// <exception cref="SandboxCommandExitException">The command exited with a non-zero exit code.</exception>
    public async Task<SandboxCommandResult> WaitAsync(CancellationToken cancellationToken = default)
    {
        var result = await execution.Completion.WaitAsync(cancellationToken).ConfigureAwait(false);
        if (result.ExitCode != 0)
        {
            throw new SandboxCommandExitException(result);
        }

        return result;
    }

    /// <summary>
    /// Sends text to this command's standard input.
    /// </summary>
    public Task SendStdinAsync(string data, CancellationToken cancellationToken = default)
    {
        return commands.SendStdinAsync(ProcessId, data, cancellationToken);
    }

    /// <summary>
    /// Sends bytes to this command's standard input.
    /// </summary>
    public Task SendStdinAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken = default)
    {
        return commands.SendStdinAsync(ProcessId, data, cancellationToken);
    }

    /// <summary>
    /// Closes this command's standard input, signaling end-of-file.
    /// </summary>
    public Task CloseStdinAsync(CancellationToken cancellationToken = default)
    {
        return commands.CloseStdinAsync(ProcessId, cancellationToken);
    }

    /// <summary>
    /// Kills this command with SIGKILL.
    /// </summary>
    public Task<bool> KillAsync(CancellationToken cancellationToken = default)
    {
        return commands.KillAsync(ProcessId, cancellationToken);
    }

    /// <summary>
    /// Stops receiving command events without killing the command.
    /// </summary>
    public ValueTask DisconnectAsync()
    {
        return execution.DisposeAsync();
    }

    /// <inheritdoc/>
    public ValueTask DisposeAsync()
    {
        return execution.DisposeAsync();
    }
}
