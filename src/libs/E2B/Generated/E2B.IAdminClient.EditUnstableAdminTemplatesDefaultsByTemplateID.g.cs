#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Update a default template as admin<br/>
        /// Updates the description of a default template. Returns 404 when the template is not a default template.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminDefaultTemplate> EditUnstableAdminTemplatesDefaultsByTemplateIDAsync(
            string templateID,

            global::E2B.AdminDefaultTemplateUpdateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a default template as admin<br/>
        /// Updates the description of a default template. Returns 404 when the template is not a default template.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminDefaultTemplate>> EditUnstableAdminTemplatesDefaultsByTemplateIDAsResponseAsync(
            string templateID,

            global::E2B.AdminDefaultTemplateUpdateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a default template as admin<br/>
        /// Updates the description of a default template. Returns 404 when the template is not a default template.
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="description">
        /// New description of the default template; null or blank clears it
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminDefaultTemplate> EditUnstableAdminTemplatesDefaultsByTemplateIDAsync(
            string templateID,
            string? description = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}