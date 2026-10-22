#nullable enable

namespace E2B
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// List template tag groups<br/>
        /// Lists the template's tags that have at least one ready build, each with its most recent ready assignments, paginated over tags with a keyset cursor. Returns 404 when the template does not exist or belongs to another team.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="assignmentLimit">
        /// Default Value: 6
        /// </param>
        /// <param name="tagsLimit">
        /// Default Value: 25
        /// </param>
        /// <param name="tagsCursor"></param>
        /// <param name="search"></param>
        /// <param name="sort">
        /// Default Value: latest_desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateTagGroupsResponse> GetTemplatesByTemplateIDTagsGroupsAsync(
            string templateID,
            int? assignmentLimit = default,
            int? tagsLimit = default,
            string? tagsCursor = default,
            string? search = default,
            global::E2B.GetTemplatesTagsGroupsSort? sort = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List template tag groups<br/>
        /// Lists the template's tags that have at least one ready build, each with its most recent ready assignments, paginated over tags with a keyset cursor. Returns 404 when the template does not exist or belongs to another team.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="assignmentLimit">
        /// Default Value: 6
        /// </param>
        /// <param name="tagsLimit">
        /// Default Value: 25
        /// </param>
        /// <param name="tagsCursor"></param>
        /// <param name="search"></param>
        /// <param name="sort">
        /// Default Value: latest_desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateTagGroupsResponse>> GetTemplatesByTemplateIDTagsGroupsAsResponseAsync(
            string templateID,
            int? assignmentLimit = default,
            int? tagsLimit = default,
            string? tagsCursor = default,
            string? search = default,
            global::E2B.GetTemplatesTagsGroupsSort? sort = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}