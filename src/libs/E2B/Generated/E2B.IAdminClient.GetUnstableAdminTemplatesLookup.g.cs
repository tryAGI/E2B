#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Look up a template as admin<br/>
        /// Resolves `query` as, in order: a build ID (a UUID, matched to the template of the build's newest assignment, with no fallback), a template ID, or a template name (`namespace/alias`, or an alias without a namespace). Returns the template with its owning team and its newest builds. Deleted templates are not found.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTemplateLookup> GetUnstableAdminTemplatesLookupAsync(
            string query,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Look up a template as admin<br/>
        /// Resolves `query` as, in order: a build ID (a UUID, matched to the template of the build's newest assignment, with no fallback), a template ID, or a template name (`namespace/alias`, or an alias without a namespace). Returns the template with its owning team and its newest builds. Deleted templates are not found.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTemplateLookup>> GetUnstableAdminTemplatesLookupAsResponseAsync(
            string query,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}