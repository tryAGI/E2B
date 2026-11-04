#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Record that a cluster is being deleted.<br/>
        /// Records that the caller is deleting the cluster, for a caller that deletes the cluster's teams before the cluster itself. Refused while the cluster has deletion protection turned on; a protection change in flight commits before or after the check, never between. Once recorded, deletion protection cannot be turned on, so the cluster delete that follows is not refused for protection, and no team can be newly assigned to the cluster. An assignment either commits before the deletion is recorded, where the caller's next project listing finds it, or is refused with cluster_assignment_cluster_deleting. Succeeds when the cluster is absent. Repeating the request succeeds. The local cluster's nil ID is rejected.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementRequestClusterDeletionAsync(
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record that a cluster is being deleted.<br/>
        /// Records that the caller is deleting the cluster, for a caller that deletes the cluster's teams before the cluster itself. Refused while the cluster has deletion protection turned on; a protection change in flight commits before or after the check, never between. Once recorded, deletion protection cannot be turned on, so the cluster delete that follows is not refused for protection, and no team can be newly assigned to the cluster. An assignment either commits before the deletion is recorded, where the caller's next project listing finds it, or is refused with cluster_assignment_cluster_deleting. Succeeds when the cluster is absent. Repeating the request succeeds. The local cluster's nil ID is rejected.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementRequestClusterDeletionAsResponseAsync(
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}