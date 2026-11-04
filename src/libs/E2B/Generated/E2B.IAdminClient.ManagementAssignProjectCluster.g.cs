#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Assign a cluster to a project.<br/>
        /// Assigns the cluster when the project has no cluster assigned. Replaying the identical assignment succeeds; replacing a different assigned cluster returns a conflict. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementAssignProjectClusterAsync(
            string projectID,
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign a cluster to a project.<br/>
        /// Assigns the cluster when the project has no cluster assigned. Replaying the identical assignment succeeds; replacing a different assigned cluster returns a conflict. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementAssignProjectClusterAsResponseAsync(
            string projectID,
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}