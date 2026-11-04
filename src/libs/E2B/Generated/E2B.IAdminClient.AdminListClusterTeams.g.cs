#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List a cluster's teams as admin<br/>
        /// Lists the teams assigned to the cluster.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="sortBy">
        /// Default Value: createdAt
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterTeamListResponse> AdminListClusterTeamsAsync(
            string clusterID,
            int? limit = default,
            int? offset = default,
            global::E2B.AdminListClusterTeamsSortBy? sortBy = default,
            global::E2B.AdminListClusterTeamsSortOrder? sortOrder = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a cluster's teams as admin<br/>
        /// Lists the teams assigned to the cluster.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="sortBy">
        /// Default Value: createdAt
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.ClusterTeamListResponse>> AdminListClusterTeamsAsResponseAsync(
            string clusterID,
            int? limit = default,
            int? offset = default,
            global::E2B.AdminListClusterTeamsSortBy? sortBy = default,
            global::E2B.AdminListClusterTeamsSortOrder? sortOrder = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}