#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Add a template alias without a namespace as admin<br/>
        /// Adds an alias without a namespace to a template, so the template resolves by that name for every team. The alias follows the rules of template names (lowercase letters, digits, `-` and `_`) and cannot equal a template ID. Returns 404 when the template does not exist and 409 when the alias is taken.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTemplateAlias> CreateUnstableAdminTemplatesAliasesAsync(

            global::E2B.AdminTemplateAliasCreateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a template alias without a namespace as admin<br/>
        /// Adds an alias without a namespace to a template, so the template resolves by that name for every team. The alias follows the rules of template names (lowercase letters, digits, `-` and `_`) and cannot equal a template ID. Returns 404 when the template does not exist and 409 when the alias is taken.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTemplateAlias>> CreateUnstableAdminTemplatesAliasesAsResponseAsync(

            global::E2B.AdminTemplateAliasCreateRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a template alias without a namespace as admin<br/>
        /// Adds an alias without a namespace to a template, so the template resolves by that name for every team. The alias follows the rules of template names (lowercase letters, digits, `-` and `_`) and cannot equal a template ID. Returns 404 when the template does not exist and 409 when the alias is taken.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template the alias resolves to
        /// </param>
        /// <param name="alias">
        /// The alias, without a namespace or tag
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTemplateAlias> CreateUnstableAdminTemplatesAliasesAsync(
            string templateID,
            string alias,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}