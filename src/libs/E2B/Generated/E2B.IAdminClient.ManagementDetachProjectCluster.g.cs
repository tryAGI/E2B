#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Detach a cluster assignment from a project.<br/>
        /// Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementDetachProjectClusterAsync(
            string projectID,
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach a cluster assignment from a project.<br/>
        /// Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementDetachProjectClusterAsResponseAsync(
            string projectID,
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}