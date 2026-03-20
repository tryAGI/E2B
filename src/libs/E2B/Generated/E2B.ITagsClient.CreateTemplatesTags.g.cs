#nullable enable

namespace E2B
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Assign tag(s) to a template build
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AssignedTemplateTags> CreateTemplatesTagsAsync(

            global::E2B.AssignTemplateTagsRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AssignedTemplateTags> CreateTemplatesTagsAsync(
            string target,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}