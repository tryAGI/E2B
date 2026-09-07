#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List recent scaling errors of a rig<br/>
        /// List recent scaling errors on the rig's scaling group (e.g. failed instance creations due to resource exhaustion), newest first.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.RigError>> GetClustersByClusterIDRigsByRigIDErrorsAsync(
            global::System.Guid clusterID,
            string rigID,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List recent scaling errors of a rig<br/>
        /// List recent scaling errors on the rig's scaling group (e.g. failed instance creations due to resource exhaustion), newest first.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.RigError>>> GetClustersByClusterIDRigsByRigIDErrorsAsResponseAsync(
            global::System.Guid clusterID,
            string rigID,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}