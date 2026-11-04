#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Make a build the current build of a sandbox's snapshot<br/>
        /// Assigns a ready build of the sandbox's snapshot template to the template<br/>
        /// again under the default tag, so the sandbox resumes from that build.<br/>
        /// The snapshot takes the restored build's kind, filesystem-only or<br/>
        /// memory.<br/>
        /// Answers 404 when the sandbox has no snapshot, its snapshot template is<br/>
        /// deleted, or the build is not assigned to that template under the<br/>
        /// default tag, and 409 when the build is not ready or is already the<br/>
        /// current build.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminSandboxBuildRestoreResult> CreateUnstableAdminSandboxesBySandboxIDBuildsRestoreAsync(
            string sandboxID,

            global::E2B.AdminSandboxBuildRestoreRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make a build the current build of a sandbox's snapshot<br/>
        /// Assigns a ready build of the sandbox's snapshot template to the template<br/>
        /// again under the default tag, so the sandbox resumes from that build.<br/>
        /// The snapshot takes the restored build's kind, filesystem-only or<br/>
        /// memory.<br/>
        /// Answers 404 when the sandbox has no snapshot, its snapshot template is<br/>
        /// deleted, or the build is not assigned to that template under the<br/>
        /// default tag, and 409 when the build is not ready or is already the<br/>
        /// current build.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminSandboxBuildRestoreResult>> CreateUnstableAdminSandboxesBySandboxIDBuildsRestoreAsResponseAsync(
            string sandboxID,

            global::E2B.AdminSandboxBuildRestoreRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make a build the current build of a sandbox's snapshot<br/>
        /// Assigns a ready build of the sandbox's snapshot template to the template<br/>
        /// again under the default tag, so the sandbox resumes from that build.<br/>
        /// The snapshot takes the restored build's kind, filesystem-only or<br/>
        /// memory.<br/>
        /// Answers 404 when the sandbox has no snapshot, its snapshot template is<br/>
        /// deleted, or the build is not assigned to that template under the<br/>
        /// default tag, and 409 when the build is not ready or is already the<br/>
        /// current build.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="buildID">
        /// Build to make current. It must be ready and already assigned to the<br/>
        /// sandbox's snapshot template under the default tag.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminSandboxBuildRestoreResult> CreateUnstableAdminSandboxesBySandboxIDBuildsRestoreAsync(
            string sandboxID,
            global::System.Guid buildID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}