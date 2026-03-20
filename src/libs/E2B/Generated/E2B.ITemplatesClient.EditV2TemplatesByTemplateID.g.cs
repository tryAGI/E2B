#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateUpdateResponse> EditV2TemplatesByTemplateIDAsync(
            string templateID,

            global::E2B.TemplateUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateUpdateResponse> EditV2TemplatesByTemplateIDAsync(
            string templateID,
            bool? @public = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}