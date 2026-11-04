#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Search template aliases as admin<br/>
        /// Finds the templates whose ID equals `search`, or that own an alias equal to `search` in any namespace, with their owning team and all their aliases. Deleted templates are left out. Results are ordered by template ID; the next page's token is returned in `X-Next-Token`.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliases>> GetUnstableAdminTemplatesAliasesAsync(
            string search,
            string? nextToken = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search template aliases as admin<br/>
        /// Finds the templates whose ID equals `search`, or that own an alias equal to `search` in any namespace, with their owning team and all their aliases. Deleted templates are left out. Results are ordered by template ID; the next page's token is returned in `X-Next-Token`.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliases>>> GetUnstableAdminTemplatesAliasesAsResponseAsync(
            string search,
            string? nextToken = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}