#nullable enable

namespace E2B
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Check template tag<br/>
        /// Checks whether a tag of the template has at least one ready build. Returns 404 when the template does not exist or belongs to another team.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="tag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateTagExistsResponse> GetTemplatesByTemplateIDTagsExistsAsync(
            string templateID,
            string tag,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check template tag<br/>
        /// Checks whether a tag of the template has at least one ready build. Returns 404 when the template does not exist or belongs to another team.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="tag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateTagExistsResponse>> GetTemplatesByTemplateIDTagsExistsAsResponseAsync(
            string templateID,
            string tag,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}