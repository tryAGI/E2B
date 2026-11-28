#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Resolve template names as admin<br/>
        /// For each name, reports the template that holds it as an alias without a namespace and the template that holds it in `namespace`, each with whether the template is public. A name no template holds in that place answers null there. Each template found also lists every alias it has, in any namespace. Deleted templates are left out. Names are matched exactly and answered in the order given.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTemplateAliasResolveResponse> CreateUnstableAdminTemplatesAliasesResolveAsync(

            global::E2B.AdminTemplateAliasResolveRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve template names as admin<br/>
        /// For each name, reports the template that holds it as an alias without a namespace and the template that holds it in `namespace`, each with whether the template is public. A name no template holds in that place answers null there. Each template found also lists every alias it has, in any namespace. Deleted templates are left out. Names are matched exactly and answered in the order given.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTemplateAliasResolveResponse>> CreateUnstableAdminTemplatesAliasesResolveAsResponseAsync(

            global::E2B.AdminTemplateAliasResolveRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve template names as admin<br/>
        /// For each name, reports the template that holds it as an alias without a namespace and the template that holds it in `namespace`, each with whether the template is public. A name no template holds in that place answers null there. Each template found also lists every alias it has, in any namespace. Deleted templates are left out. Names are matched exactly and answered in the order given.
        /// </summary>
        /// <param name="namespace">
        /// Namespace to resolve each name in, next to the alias without a namespace
        /// </param>
        /// <param name="names">
        /// Aliases to resolve, matched exactly
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTemplateAliasResolveResponse> CreateUnstableAdminTemplatesAliasesResolveAsync(
            string @namespace,
            global::System.Collections.Generic.IList<string> names,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}