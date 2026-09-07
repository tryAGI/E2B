#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Terminate an instance of a rig<br/>
        /// Terminate an instance in whichever rig's scaling group it belongs to. The caller chooses whether the rig shrinks or the instance is replaced.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="instanceID"></param>
        /// <param name="decrementDesired"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteClustersByClusterIDRigsInstancesByInstanceIDAsync(
            global::System.Guid clusterID,
            string instanceID,
            bool decrementDesired,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate an instance of a rig<br/>
        /// Terminate an instance in whichever rig's scaling group it belongs to. The caller chooses whether the rig shrinks or the instance is replaced.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="instanceID"></param>
        /// <param name="decrementDesired"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> DeleteClustersByClusterIDRigsInstancesByInstanceIDAsResponseAsync(
            global::System.Guid clusterID,
            string instanceID,
            bool decrementDesired,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}