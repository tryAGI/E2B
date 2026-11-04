#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Check cluster destroy readiness.<br/>
        /// Checks whether the cluster has deletion protection turned on, or more than one team uses this exact cluster, either as an assigned team or as the owner of active templates or snapshots on it. One team's own templates and snapshots do not block this check, because deleting the cluster soft-deletes them. Soft-deleted history does not count. Returns success if the cluster is absent. This read does not change resources or prevent later assignments or template creation.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementClusterDestroyReadinessAsync(
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check cluster destroy readiness.<br/>
        /// Checks whether the cluster has deletion protection turned on, or more than one team uses this exact cluster, either as an assigned team or as the owner of active templates or snapshots on it. One team's own templates and snapshots do not block this check, because deleting the cluster soft-deletes them. Soft-deleted history does not count. Returns success if the cluster is absent. This read does not change resources or prevent later assignments or template creation.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementClusterDestroyReadinessAsResponseAsync(
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}