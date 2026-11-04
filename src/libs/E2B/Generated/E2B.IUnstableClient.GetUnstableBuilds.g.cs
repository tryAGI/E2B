#nullable enable

namespace E2B
{
    public partial interface IUnstableClient
    {
        /// <summary>
        /// List team builds<br/>
        /// Lists the team's builds, newest first, with an optional filter by build ID, template ID or template alias and by status. `nextCursor` continues the listing. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="buildIdOrTemplate"></param>
        /// <param name="statuses"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.BuildsListResponse> GetUnstableBuildsAsync(
            string? buildIdOrTemplate = default,
            global::System.Collections.Generic.IList<global::E2B.BuildStatus>? statuses = default,
            int? limit = default,
            string? cursor = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List team builds<br/>
        /// Lists the team's builds, newest first, with an optional filter by build ID, template ID or template alias and by status. `nextCursor` continues the listing. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="buildIdOrTemplate"></param>
        /// <param name="statuses"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.BuildsListResponse>> GetUnstableBuildsAsResponseAsync(
            string? buildIdOrTemplate = default,
            global::System.Collections.Generic.IList<global::E2B.BuildStatus>? statuses = default,
            int? limit = default,
            string? cursor = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}