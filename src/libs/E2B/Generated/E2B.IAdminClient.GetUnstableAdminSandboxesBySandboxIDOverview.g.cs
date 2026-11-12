#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Sandbox overview<br/>
        /// Reads a sandbox's team, snapshot template, most recent pause and newest<br/>
        /// default-tag build from the database. The team comes from the<br/>
        /// stopped-sandbox log, or from the snapshot when the sandbox has not<br/>
        /// stopped. Returns 404 when neither knows the sandbox. A sandbox without<br/>
        /// a snapshot returns null `snapshotTemplateId`, `lastPause` and<br/>
        /// `latestBuild`.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminSandboxOverview> GetUnstableAdminSandboxesBySandboxIDOverviewAsync(
            string sandboxID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sandbox overview<br/>
        /// Reads a sandbox's team, snapshot template, most recent pause and newest<br/>
        /// default-tag build from the database. The team comes from the<br/>
        /// stopped-sandbox log, or from the snapshot when the sandbox has not<br/>
        /// stopped. Returns 404 when neither knows the sandbox. A sandbox without<br/>
        /// a snapshot returns null `snapshotTemplateId`, `lastPause` and<br/>
        /// `latestBuild`.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminSandboxOverview>> GetUnstableAdminSandboxesBySandboxIDOverviewAsResponseAsync(
            string sandboxID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}