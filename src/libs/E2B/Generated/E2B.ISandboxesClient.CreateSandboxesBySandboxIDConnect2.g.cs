#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Connect sandbox (v2)<br/>
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended. The request body is optional; an omitted timeout defaults to 300 seconds.
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
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended. The request body is optional; an omitted timeout defaults to 300 seconds.
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
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended. The request body is optional; an omitted timeout defaults to 300 seconds.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="memory">
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesBySandboxIDConnect2Async(
            string sandboxID,
            int? timeout = default,
            bool? memory = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}