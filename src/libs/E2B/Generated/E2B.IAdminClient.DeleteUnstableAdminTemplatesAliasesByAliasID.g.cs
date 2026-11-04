#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Remove a template alias without a namespace as admin<br/>
        /// Removes an alias without a namespace. A namespaced alias is not removed and answers 404.
        /// </summary>
        /// <param name="aliasID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTemplateAliasDeleted> DeleteUnstableAdminTemplatesAliasesByAliasIDAsync(
            global::System.Guid aliasID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a template alias without a namespace as admin<br/>
        /// Removes an alias without a namespace. A namespaced alias is not removed and answers 404.
        /// </summary>
        /// <param name="aliasID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTemplateAliasDeleted>> DeleteUnstableAdminTemplatesAliasesByAliasIDAsResponseAsync(
            global::System.Guid aliasID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}