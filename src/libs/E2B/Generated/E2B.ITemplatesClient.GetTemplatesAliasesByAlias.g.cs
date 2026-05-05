#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Check if template with given alias exists
        /// </summary>
        /// <param name="alias">
        /// Template alias
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateAliasResponse> GetTemplatesAliasesByAliasAsync(
            string alias,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check if template with given alias exists
        /// </summary>
        /// <param name="alias">
        /// Template alias
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateAliasResponse>> GetTemplatesAliasesByAliasAsResponseAsync(
            string alias,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}