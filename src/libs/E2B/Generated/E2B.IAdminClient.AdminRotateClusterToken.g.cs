#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Rotate a cluster's token as admin<br/>
        /// Replaces the token used to reach the cluster. The previous token stops working at once. No route returns a cluster's token.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminRotateClusterTokenAsync(
            string clusterID,

            global::E2B.ClusterTokenRotateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a cluster's token as admin<br/>
        /// Replaces the token used to reach the cluster. The previous token stops working at once. No route returns a cluster's token.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> AdminRotateClusterTokenAsResponseAsync(
            string clusterID,

            global::E2B.ClusterTokenRotateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a cluster's token as admin<br/>
        /// Replaces the token used to reach the cluster. The previous token stops working at once. No route returns a cluster's token.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="token">
        /// New cluster access token. Write-only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AdminRotateClusterTokenAsync(
            string clusterID,
            string token,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}