#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Get a sandbox's team and state<br/>
        /// Reads the team and state of a sandbox from its latest lifecycle event.<br/>
        /// The state lags the sandbox while that event is in flight. A sandbox<br/>
        /// whose events have expired is not found.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminSandbox> GetAdminSandboxesBySandboxIDAsync(
            string sandboxID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a sandbox's team and state<br/>
        /// Reads the team and state of a sandbox from its latest lifecycle event.<br/>
        /// The state lags the sandbox while that event is in flight. A sandbox<br/>
        /// whose events have expired is not found.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminSandbox>> GetAdminSandboxesBySandboxIDAsResponseAsync(
            string sandboxID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}