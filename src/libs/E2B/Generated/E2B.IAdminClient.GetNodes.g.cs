#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List all nodes
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.Node>> GetNodesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}