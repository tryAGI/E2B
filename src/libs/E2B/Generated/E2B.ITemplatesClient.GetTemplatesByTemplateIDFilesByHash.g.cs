#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get an upload link for a tar file containing build layer files
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="hash">
        /// Hash of the files
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateBuildFileUpload> GetTemplatesByTemplateIDFilesByHashAsync(
            string templateID,
            string hash,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}