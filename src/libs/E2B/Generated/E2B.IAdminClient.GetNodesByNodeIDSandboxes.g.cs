#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Node sandboxes<br/>
        /// List the sandboxes the API confirms are running on the node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.NodeSandboxes> GetNodesByNodeIDSandboxesAsync(
            string nodeID,
            global::System.Guid? clusterID = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Node sandboxes<br/>
        /// List the sandboxes the API confirms are running on the node
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.NodeSandboxes>> GetNodesByNodeIDSandboxesAsResponseAsync(
            string nodeID,
            global::System.Guid? clusterID = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}