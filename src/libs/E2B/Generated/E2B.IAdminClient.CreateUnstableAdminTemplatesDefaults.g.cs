#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Add a default template as admin<br/>
        /// Makes a template one of the platform's default templates. Returns 404 when the template does not exist and 409 when it is already a default template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminDefaultTemplate> CreateUnstableAdminTemplatesDefaultsAsync(

            global::E2B.AdminDefaultTemplateCreateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a default template as admin<br/>
        /// Makes a template one of the platform's default templates. Returns 404 when the template does not exist and 409 when it is already a default template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminDefaultTemplate>> CreateUnstableAdminTemplatesDefaultsAsResponseAsync(

            global::E2B.AdminDefaultTemplateCreateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a default template as admin<br/>
        /// Makes a template one of the platform's default templates. Returns 404 when the template does not exist and 409 when it is already a default template.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template to make a default template
        /// </param>
        /// <param name="description">
        /// Description of the default template; blank is stored as none
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminDefaultTemplate> CreateUnstableAdminTemplatesDefaultsAsync(
            string templateID,
            string? description = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}