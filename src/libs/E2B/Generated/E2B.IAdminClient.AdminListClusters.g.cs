#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List clusters as admin<br/>
        /// Lists the registered clusters with the number of teams assigned to each. Never returns a cluster's token. The local cluster is not a registered cluster and is not listed.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="search"></param>
        /// <param name="sortBy">
        /// Default Value: endpoint
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterListResponse> AdminListClustersAsync(
            int? limit = default,
            int? offset = default,
            string? search = default,
            global::E2B.AdminListClustersSortBy? sortBy = default,
            global::E2B.AdminListClustersSortOrder? sortOrder = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List clusters as admin<br/>
        /// Lists the registered clusters with the number of teams assigned to each. Never returns a cluster's token. The local cluster is not a registered cluster and is not listed.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="search"></param>
        /// <param name="sortBy">
        /// Default Value: endpoint
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.ClusterListResponse>> AdminListClustersAsResponseAsync(
            int? limit = default,
            int? offset = default,
            string? search = default,
            global::E2B.AdminListClustersSortBy? sortBy = default,
            global::E2B.AdminListClustersSortOrder? sortOrder = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}