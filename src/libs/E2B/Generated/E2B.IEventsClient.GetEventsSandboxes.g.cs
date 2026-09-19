#nullable enable

namespace E2B
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get all sandbox events for the team associated with the API key
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="orderAsc">
        /// Default Value: false
        /// </param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.SandboxEvent>> GetEventsSandboxesAsync(
            int? offset = default,
            int? limit = default,
            bool? orderAsc = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all sandbox events for the team associated with the API key
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="orderAsc">
        /// Default Value: false
        /// </param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.SandboxEvent>>> GetEventsSandboxesAsResponseAsync(
            int? offset = default,
            int? limit = default,
            bool? orderAsc = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}