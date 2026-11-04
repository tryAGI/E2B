#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Update a cluster as admin<br/>
        /// Writes only the properties present in the body. `endpoint` and `endpointTls` change where orchestration traffic for every team on the cluster goes, `sandboxProxyDomain` changes the public URL of every sandbox on it, and `authOrgId` changes how the cluster authenticates. A body with no property returns 400. Another cluster using the auth organization returns 409, and so does turning deletion protection on after the cluster's deletion is recorded. The token is rotated through `PUT /unstable/admin/clusters/{clusterID}/token`.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterDetail> AdminUpdateClusterAsync(
            string clusterID,

            global::E2B.ClusterUpdateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a cluster as admin<br/>
        /// Writes only the properties present in the body. `endpoint` and `endpointTls` change where orchestration traffic for every team on the cluster goes, `sandboxProxyDomain` changes the public URL of every sandbox on it, and `authOrgId` changes how the cluster authenticates. A body with no property returns 400. Another cluster using the auth organization returns 409, and so does turning deletion protection on after the cluster's deletion is recorded. The token is rotated through `PUT /unstable/admin/clusters/{clusterID}/token`.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.ClusterDetail>> AdminUpdateClusterAsResponseAsync(
            string clusterID,

            global::E2B.ClusterUpdateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a cluster as admin<br/>
        /// Writes only the properties present in the body. `endpoint` and `endpointTls` change where orchestration traffic for every team on the cluster goes, `sandboxProxyDomain` changes the public URL of every sandbox on it, and `authOrgId` changes how the cluster authenticates. A body with no property returns 400. Another cluster using the auth organization returns 409, and so does turning deletion protection on after the cluster's deletion is recorded. The token is rotated through `PUT /unstable/admin/clusters/{clusterID}/token`.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="endpointTls"></param>
        /// <param name="sandboxProxyDomain"></param>
        /// <param name="authOrgId"></param>
        /// <param name="deletionProtection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ClusterDetail> AdminUpdateClusterAsync(
            string clusterID,
            string? name = default,
            string? endpoint = default,
            bool? endpointTls = default,
            string? sandboxProxyDomain = default,
            string? authOrgId = default,
            bool? deletionProtection = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}