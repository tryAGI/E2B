#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Remove a default template as admin<br/>
        /// Stops a template being one of the platform's default templates. The template itself is not changed. Returns 404 when the template is not a default template.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteUnstableAdminTemplatesDefaultsByTemplateIDAsync(
            string templateID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a default template as admin<br/>
        /// Stops a template being one of the platform's default templates. The template itself is not changed. Returns 404 when the template is not a default template.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> DeleteUnstableAdminTemplatesDefaultsByTemplateIDAsResponseAsync(
            string templateID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}