#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List rigs of a cluster<br/>
        /// List the orchestrator node pools ("rigs") of a cluster with a snapshot of their scaling groups. Forwarded to the cluster's edge service; a cluster with no rig management configured returns an empty list, and the local cluster answers 501.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.Rig>> GetClustersByClusterIDRigsAsync(
            global::System.Guid clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List rigs of a cluster<br/>
        /// List the orchestrator node pools ("rigs") of a cluster with a snapshot of their scaling groups. Forwarded to the cluster's edge service; a cluster with no rig management configured returns an empty list, and the local cluster answers 501.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.Rig>>> GetClustersByClusterIDRigsAsResponseAsync(
            global::System.Guid clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}