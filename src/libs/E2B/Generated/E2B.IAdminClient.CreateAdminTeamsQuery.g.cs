#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// List teams as admin<br/>
        /// Lists teams matching the filters in the request body, with each team's<br/>
        /// member count, and its running sandbox count when sorted by running<br/>
        /// sandboxes. A read despite the POST: the body carries a project ID list<br/>
        /// too long for a query string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTeamList> CreateAdminTeamsQueryAsync(

            global::E2B.AdminTeamListRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List teams as admin<br/>
        /// Lists teams matching the filters in the request body, with each team's<br/>
        /// member count, and its running sandbox count when sorted by running<br/>
        /// sandboxes. A read despite the POST: the body carries a project ID list<br/>
        /// too long for a query string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTeamList>> CreateAdminTeamsQueryAsResponseAsync(

            global::E2B.AdminTeamListRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List teams as admin<br/>
        /// Lists teams matching the filters in the request body, with each team's<br/>
        /// member count, and its running sandbox count when sorted by running<br/>
        /// sandboxes. A read despite the POST: the body carries a project ID list<br/>
        /// too long for a query string.
        /// </summary>
        /// <param name="projectIds">
        /// Only list these teams. An empty list matches no team; omit it to list every team.
        /// </param>
        /// <param name="search">
        /// A team ID, as a UUID or public project ID, matches that team exactly. Any other text matches a substring of the email, name or slug, ignoring case.
        /// </param>
        /// <param name="hideBanned">
        /// Leave out banned teams<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hideBlocked">
        /// Leave out blocked teams<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAfter">
        /// Only list teams created at or after this time
        /// </param>
        /// <param name="createdBefore">
        /// Only list teams created at or before this time
        /// </param>
        /// <param name="sortBy">
        /// Column to order by, with newer teams first among equal values. Omit it<br/>
        /// to list enterprise tiers first, then pro tiers, then the rest, each<br/>
        /// newest first.
        /// </param>
        /// <param name="sortOrder">
        /// Ignored when `sortBy` is omitted.
        /// </param>
        /// <param name="limit">
        /// Maximum number of teams to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Number of matching teams to skip<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTeamList> CreateAdminTeamsQueryAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            string? search = default,
            bool? hideBanned = default,
            bool? hideBlocked = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::E2B.AdminTeamListSortField? sortBy = default,
            global::E2B.OrderDirection? sortOrder = default,
            int? limit = default,
            int? offset = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}