#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Template info (v2)<br/>
        /// Get a template by its ID or name, with its default build and without its other builds.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateV2> GetTemplatesByTemplateID2Async(
            string templateID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Template info (v2)<br/>
        /// Get a template by its ID or name, with its default build and without its other builds.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateV2>> GetTemplatesByTemplateID2AsResponseAsync(
            string templateID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}