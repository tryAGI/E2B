#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Set the capacity of a rig<br/>
        /// Set the desired instance count on the rig's scaling group. The value is passed to the cloud provider unchanged; violations of the group's bounds or conflicting concurrent operations surface as errors.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task PutClustersByClusterIDRigsByRigIDCapacityAsync(
            global::System.Guid clusterID,
            string rigID,

            global::E2B.RigCapacityChange request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the capacity of a rig<br/>
        /// Set the desired instance count on the rig's scaling group. The value is passed to the cloud provider unchanged; violations of the group's bounds or conflicting concurrent operations surface as errors.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> PutClustersByClusterIDRigsByRigIDCapacityAsResponseAsync(
            global::System.Guid clusterID,
            string rigID,

            global::E2B.RigCapacityChange request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the capacity of a rig<br/>
        /// Set the desired instance count on the rig's scaling group. The value is passed to the cloud provider unchanged; violations of the group's bounds or conflicting concurrent operations surface as errors.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="rigID"></param>
        /// <param name="desired">
        /// Absolute desired number of instances in the rig
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutClustersByClusterIDRigsByRigIDCapacityAsync(
            global::System.Guid clusterID,
            string rigID,
            int desired,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}