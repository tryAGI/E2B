#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List all templates
        /// </summary>
        /// <param name="teamID">
        /// Identifier of the team
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.Template>> GetTemplatesAsync(
            string? teamID = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}