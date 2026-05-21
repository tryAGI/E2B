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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDRefreshesAsync(
            string sandboxID,

            global::E2B.CreateSandboxesRefreshesRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refresh the sandbox extending its time to live
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> CreateSandboxesBySandboxIDRefreshesAsResponseAsync(
            string sandboxID,

            global::E2B.CreateSandboxesRefreshesRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refresh the sandbox extending its time to live
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="duration">
        /// Duration for which the sandbox should be kept alive in seconds
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDRefreshesAsync(
            string sandboxID,
            int? duration = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}