#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Connect sandbox (v2)<br/>
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended. The request body is optional; an omitted timeout defaults to 300 seconds. Answers 409 with error_code sandbox_snapshot_guest_agent_unresponsive when the paused sandbox's snapshot was taken while its guest agent was not responding and the request did not ask for `memory: false`.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesBySandboxIDConnect2Async(
            string sandboxID,

            global::E2B.ConnectSandboxV2 request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect sandbox (v2)<br/>
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended. The request body is optional; an omitted timeout defaults to 300 seconds. Answers 409 with error_code sandbox_snapshot_guest_agent_unresponsive when the paused sandbox's snapshot was taken while its guest agent was not responding and the request did not ask for `memory: false`.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.Sandbox>> CreateSandboxesBySandboxIDConnect2AsResponseAsync(
            string sandboxID,

            global::E2B.ConnectSandboxV2 request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect sandbox (v2)<br/>
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended. The request body is optional; an omitted timeout defaults to 300 seconds. Answers 409 with error_code sandbox_snapshot_guest_agent_unresponsive when the paused sandbox's snapshot was taken while its guest agent was not responding and the request did not ask for `memory: false`.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="memory">
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore. A snapshot taken while the sandbox guest agent was not responding (envdUnresponsiveAtPause) can only be resumed this way, and needs no enablement.
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB when this connect resumes it, from its memory snapshot or by cold-booting (memory false). Defaults to the memory the sandbox had when it was paused; at least that, and at most the template's maxMemoryMB, in steps of 128 MiB above its memoryMB. A sandbox that is already running keeps its size and the field is ignored. For a paused sandbox, a size the snapshot or the team cannot take is refused with 400; a size it can take applies only when this connect resumes the sandbox, and is ignored when another request is already resuming it. The response's memoryMB reports the size the sandbox runs with.
        /// </param>
        /// <param name="cpuCount">
        /// Online vCPU target for the sandbox when this connect resumes it, from its memory snapshot or by cold-booting (memory false). Defaults to the snapshot's cpuCount; for a resizable template (one with maxCpuCount) that count is lowered to the team's vCPU limit when above it. A requested count is at most the template's maxCpuCount (fixed-size templates accept only their cpuCount) and the team's vCPU limit, and is refused when resizable templates are not enabled for the team. Like memoryMB: a sandbox that is already running keeps its count and the field is ignored. For a paused sandbox, a count the snapshot or the team cannot take is refused with 400; a count it can take applies only when this connect resumes the sandbox, and is ignored when another request is already resuming it. The response's cpuCount reports the count the sandbox runs with.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesBySandboxIDConnect2Async(
            string sandboxID,
            int? timeout = default,
            bool? memory = default,
            int? memoryMB = default,
            int? cpuCount = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}