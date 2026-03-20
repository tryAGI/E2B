#nullable enable

namespace E2B
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// List all tags for a template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.TemplateTag>> GetTemplatesByTemplateIDTagsAsync(
            string templateID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}