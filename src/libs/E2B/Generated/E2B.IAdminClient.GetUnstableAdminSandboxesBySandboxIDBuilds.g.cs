#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List the builds of a sandbox's snapshot template<br/>
        /// Lists the build assignments of the template that holds the sandbox's<br/>
        /// snapshot under one tag. Assignments without a creation time are left<br/>
        /// out. A sandbox without a snapshot returns no items and a null<br/>
        /// `snapshotTemplateID`; this route does not report whether the sandbox<br/>
        /// exists.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="statusGroup"></param>
        /// <param name="tag">
        /// Default Value: default
        /// </param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminSandboxBuildList> GetUnstableAdminSandboxesBySandboxIDBuildsAsync(
            string sandboxID,
            global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuildStatusGroup>? statusGroup = default,
            string? tag = default,
            global::E2B.OrderDirection? order = default,
            int? limit = default,
            int? offset = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the builds of a sandbox's snapshot template<br/>
        /// Lists the build assignments of the template that holds the sandbox's<br/>
        /// snapshot under one tag. Assignments without a creation time are left<br/>
        /// out. A sandbox without a snapshot returns no items and a null<br/>
        /// `snapshotTemplateID`; this route does not report whether the sandbox<br/>
        /// exists.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="statusGroup"></param>
        /// <param name="tag">
        /// Default Value: default
        /// </param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminSandboxBuildList>> GetUnstableAdminSandboxesBySandboxIDBuildsAsResponseAsync(
            string sandboxID,
            global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuildStatusGroup>? statusGroup = default,
            string? tag = default,
            global::E2B.OrderDirection? order = default,
            int? limit = default,
            int? offset = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}