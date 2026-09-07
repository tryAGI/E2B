#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List the instances attached to a rig<br/>
        /// List the instances attached to the rig's scaling group with their creation time and transition state, sorted by instance ID.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.RigInstance>> GetClustersByClusterIDRigsByRigIDInstancesAsync(
            global::System.Guid clusterID,
            string rigID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the instances attached to a rig<br/>
        /// List the instances attached to the rig's scaling group with their creation time and transition state, sorted by instance ID.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.RigInstance>>> GetClustersByClusterIDRigsByRigIDInstancesAsResponseAsync(
            global::System.Guid clusterID,
            string rigID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}