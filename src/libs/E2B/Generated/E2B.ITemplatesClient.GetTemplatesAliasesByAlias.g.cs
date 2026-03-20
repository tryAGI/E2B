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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateAliasResponse> GetTemplatesAliasesByAliasAsync(
            string alias,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}