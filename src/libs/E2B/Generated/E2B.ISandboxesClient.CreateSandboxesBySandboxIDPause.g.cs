#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Pause sandbox<br/>
        /// Pause the sandbox. Answers 503 and leaves the sandbox running when it cannot be paused right now: its node is busy, it is being snapshotted, or `requireHealthyGuest` was set and the sandbox guest agent is not responding; retry later.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDPauseAsync(
            string sandboxID,

            global::E2B.SandboxPauseRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pause sandbox<br/>
        /// Pause the sandbox. Answers 503 and leaves the sandbox running when it cannot be paused right now: its node is busy, it is being snapshotted, or `requireHealthyGuest` was set and the sandbox guest agent is not responding; retry later.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> CreateSandboxesBySandboxIDPauseAsResponseAsync(
            string sandboxID,

            global::E2B.SandboxPauseRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pause sandbox<br/>
        /// Pause the sandbox. Answers 503 and leaves the sandbox running when it cannot be paused right now: its node is busy, it is being snapshotted, or `requireHealthyGuest` was set and the sandbox guest agent is not responding; retry later.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="memory">
        /// Whether to capture a full memory snapshot. When false, only the filesystem is persisted and resuming the sandbox cold-boots (reboots) it from disk, losing in-memory state, running processes, and open connections. Resume it with an explicit request (connect or resume); auto-resume, which can be triggered by arbitrary traffic, refuses such a sandbox. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requireHealthyGuest">
        /// The pause checks that the sandbox guest agent answers before it takes the snapshot. By default an unresponsive agent is recorded on the snapshot and the pause proceeds; the sandbox then shows `envdUnresponsiveAtPause` and a later resume must ask for `memory: false`, since restoring that memory would bring the unresponsive agent back. With this true, the pause is instead refused with 503 while the agent does not answer, and the sandbox keeps running. A filesystem-only pause (`memory: false`) is always refused while the agent does not answer, whatever this says.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDPauseAsync(
            string sandboxID,
            bool? memory = default,
            bool? requireHealthyGuest = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}