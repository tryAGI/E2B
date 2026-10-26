#nullable enable

namespace E2B
{
    public partial interface IUnstableClient
    {
        /// <summary>
        /// Search templates<br/>
        /// Lists the team's templates together with the platform's public default templates, which carry `isDefault: true`, with search, a visibility filter and sorts. Default templates are not listed to teams on a dedicated cluster, and those owned by another team carry zero or null usage fields. Results are newest first unless `sort` says otherwise; `nextCursor` continues the listing and is only valid with the same `sort`. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sort">
        /// Default Value: created_at_desc
        /// </param>
        /// <param name="public"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateSearchResponse> GetUnstableTemplatesSearchAsync(
            string? search = default,
            global::E2B.GetUnstableTemplatesSearchSort? sort = default,
            bool? @public = default,
            int? limit = default,
            string? cursor = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search templates<br/>
        /// Lists the team's templates together with the platform's public default templates, which carry `isDefault: true`, with search, a visibility filter and sorts. Default templates are not listed to teams on a dedicated cluster, and those owned by another team carry zero or null usage fields. Results are newest first unless `sort` says otherwise; `nextCursor` continues the listing and is only valid with the same `sort`. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sort">
        /// Default Value: created_at_desc
        /// </param>
        /// <param name="public"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateSearchResponse>> GetUnstableTemplatesSearchAsResponseAsync(
            string? search = default,
            global::E2B.GetUnstableTemplatesSearchSort? sort = default,
            bool? @public = default,
            int? limit = default,
            string? cursor = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}