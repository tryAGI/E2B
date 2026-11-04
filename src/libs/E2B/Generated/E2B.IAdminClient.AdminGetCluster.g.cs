#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Cluster as admin<br/>
        /// Returns a cluster with the first page of its assigned teams, the number of teams assigned to it and the number of live templates on it. Never returns the cluster's token.
        /// </summary>
        /// <param name="teamsLimit">
        /// Default Value: 50
        /// </param>
        /// <param name="teamsOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterDetailWithTeams> AdminGetClusterAsync(
            string clusterID,
            int? teamsLimit = default,
            int? teamsOffset = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cluster as admin<br/>
        /// Returns a cluster with the first page of its assigned teams, the number of teams assigned to it and the number of live templates on it. Never returns the cluster's token.
        /// </summary>
        /// <param name="teamsLimit">
        /// Default Value: 50
        /// </param>
        /// <param name="teamsOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.ClusterDetailWithTeams>> AdminGetClusterAsResponseAsync(
            string clusterID,
            int? teamsLimit = default,
            int? teamsOffset = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}