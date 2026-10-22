#nullable enable

namespace E2B
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// List template tag assignments<br/>
        /// Lists the ready assignments of one tag of the template, newest first, with keyset cursor pagination. Returns 404 when the template does not exist or belongs to another team.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="tag">
        /// Tag name
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateTagAssignmentsResponse> GetTemplatesByTemplateIDTagsByTagAssignmentsAsync(
            string templateID,
            string tag,
            string? cursor = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List template tag assignments<br/>
        /// Lists the ready assignments of one tag of the template, newest first, with keyset cursor pagination. Returns 404 when the template does not exist or belongs to another team.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="tag">
        /// Tag name
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateTagAssignmentsResponse>> GetTemplatesByTemplateIDTagsByTagAssignmentsAsResponseAsync(
            string templateID,
            string tag,
            string? cursor = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}