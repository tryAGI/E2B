#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Apply a project's settings revision.<br/>
        /// Replaces the complete project settings document when the revision is newer than the stored revision. Omitted settings are removed. Older and duplicate revisions leave the stored document unchanged. Every successful delivery invalidates the cached team. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementSetProjectSettingsAsync(
            string projectID,

            global::E2B.ManagementProjectSettingsRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply a project's settings revision.<br/>
        /// Replaces the complete project settings document when the revision is newer than the stored revision. Omitted settings are removed. Older and duplicate revisions leave the stored document unchanged. Every successful delivery invalidates the cached team. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementSetProjectSettingsAsResponseAsync(
            string projectID,

            global::E2B.ManagementProjectSettingsRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply a project's settings revision.<br/>
        /// Replaces the complete project settings document when the revision is newer than the stored revision. Omitted settings are removed. Older and duplicate revisions leave the stored document unchanged. Every successful delivery invalidates the cached team. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="revision">
        /// Monotonic per-project revision. Older or duplicate revisions succeed without changing stored state.
        /// </param>
        /// <param name="settings">
        /// The project's stored settings. PUT replaces the complete document.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ManagementSetProjectSettingsAsync(
            string projectID,
            long revision,
            global::E2B.ProjectSettings settings,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}