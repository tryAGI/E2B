#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Create a cluster as admin<br/>
        /// Creates a cluster whose configuration cannot be modified through this route. A new cluster starts with deletion protection turned on. Creating a cluster again with the same `cluster_id` and an identical configuration answers 201 with the stored cluster, whose deletionProtection is whatever is stored; a different configuration, or an auth organization another cluster uses, returns 409 with error_code cluster_registration_conflict. An invalid request returns 400 with error_code cluster_registration_invalid.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterDetail> AdminCreateClusterAsync(

            global::E2B.AdminClusterCreateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cluster as admin<br/>
        /// Creates a cluster whose configuration cannot be modified through this route. A new cluster starts with deletion protection turned on. Creating a cluster again with the same `cluster_id` and an identical configuration answers 201 with the stored cluster, whose deletionProtection is whatever is stored; a different configuration, or an auth organization another cluster uses, returns 409 with error_code cluster_registration_conflict. An invalid request returns 400 with error_code cluster_registration_invalid.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.ClusterDetail>> AdminCreateClusterAsResponseAsync(

            global::E2B.AdminClusterCreateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cluster as admin<br/>
        /// Creates a cluster whose configuration cannot be modified through this route. A new cluster starts with deletion protection turned on. Creating a cluster again with the same `cluster_id` and an identical configuration answers 201 with the stored cluster, whose deletionProtection is whatever is stored; a different configuration, or an auth organization another cluster uses, returns 409 with error_code cluster_registration_conflict. An invalid request returns 400 with error_code cluster_registration_invalid.
        /// </summary>
        /// <param name="clusterId">
        /// Optional stable identifier for idempotent creation. Reuse succeeds only when the immutable configuration is identical.
        /// </param>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="endpointTls"></param>
        /// <param name="token"></param>
        /// <param name="sandboxProxyDomain"></param>
        /// <param name="authOrgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterDetail> AdminCreateClusterAsync(
            string name,
            string endpoint,
            bool endpointTls,
            string token,
            global::System.Guid? clusterId = default,
            string? sandboxProxyDomain = default,
            string? authOrgId = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}