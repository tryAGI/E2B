#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Change node status<br/>
        /// Change status of a node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateNodesByNodeIDAsync(
            string nodeID,

            global::E2B.NodeStatusChange request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change node status<br/>
        /// Change status of a node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> CreateNodesByNodeIDAsResponseAsync(
            string nodeID,

            global::E2B.NodeStatusChange request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change node status<br/>
        /// Change status of a node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="clusterID">
        /// Identifier of the cluster
        /// </param>
        /// <param name="status">
        /// Status of the node.<br/>
        /// - draining: the node is bound to be shut down. It will not accept new sandboxes and will stop once all existing sandboxes are done.<br/>
        /// - standby: the node is not actively used, but it can return to ready and continue serving traffic.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateNodesByNodeIDAsync(
            string nodeID,
            global::E2B.NodeStatus status,
            global::System.Guid? clusterID = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}