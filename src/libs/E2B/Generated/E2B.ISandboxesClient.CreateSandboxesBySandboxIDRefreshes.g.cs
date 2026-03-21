#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Refresh the sandbox extending its time to live
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDRefreshesAsync(
            string sandboxID,

            global::E2B.CreateSandboxesRefreshesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refresh the sandbox extending its time to live
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="duration">
        /// Duration for which the sandbox should be kept alive in seconds
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDRefreshesAsync(
            string sandboxID,
            int? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}