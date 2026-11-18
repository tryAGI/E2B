#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List a template's builds<br/>
        /// List the builds of a template, newest first. The template is given by its ID or name. A template named `aliases` is given by its ID or by its name with the team prefix.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="statuses"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.TemplateBuildWithTags>> GetTemplatesByTemplateIDBuildsAsync(
            string templateID,
            string? nextToken = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::E2B.TemplateBuildStatus>? statuses = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a template's builds<br/>
        /// List the builds of a template, newest first. The template is given by its ID or name. A template named `aliases` is given by its ID or by its name with the team prefix.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="statuses"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.TemplateBuildWithTags>>> GetTemplatesByTemplateIDBuildsAsResponseAsync(
            string templateID,
            string? nextToken = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::E2B.TemplateBuildStatus>? statuses = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}