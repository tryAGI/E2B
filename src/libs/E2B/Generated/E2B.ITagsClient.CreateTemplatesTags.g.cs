#nullable enable

namespace E2B
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Assign tag(s) to a template build
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AssignedTemplateTags> CreateTemplatesTagsAsync(

            global::E2B.AssignTemplateTagsRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign tag(s) to a template build
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AssignedTemplateTags>> CreateTemplatesTagsAsResponseAsync(

            global::E2B.AssignTemplateTagsRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign tag(s) to a template build
        /// </summary>
        /// <param name="target">
        /// Target template in "name:tag" format
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AssignedTemplateTags> CreateTemplatesTagsAsync(
            string target,
            global::System.Collections.Generic.IList<string> tags,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}