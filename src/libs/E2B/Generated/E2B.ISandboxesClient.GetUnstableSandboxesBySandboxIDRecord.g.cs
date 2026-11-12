#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Sandbox record<br/>
        /// Returns the team's latest recorded run of the sandbox, including runs that have already ended, and whether its monitoring, logs and events data are still retained. Returns 404 when the team has no recorded run of the sandbox.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.SandboxRecord> GetUnstableSandboxesBySandboxIDRecordAsync(
            string sandboxID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sandbox record<br/>
        /// Returns the team's latest recorded run of the sandbox, including runs that have already ended, and whether its monitoring, logs and events data are still retained. Returns 404 when the team has no recorded run of the sandbox.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.SandboxRecord>> GetUnstableSandboxesBySandboxIDRecordAsResponseAsync(
            string sandboxID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}