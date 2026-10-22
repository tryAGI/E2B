#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List default templates<br/>
        /// Lists the platform's default templates, ordered by template ID. Deleted templates are left out. Templates that are not public are listed only to their own team and to admin callers. The build, resources and envd version are those of the newest ready build tagged `default`, the one a sandbox started from the template runs, and are zero or empty when there is none; `buildStatus` describes the newest build tagged `default` in any state. Usage fields (`spawnCount`, `buildCount`, `lastSpawnedAt`, `createdBy`) are reported only for the caller's own templates and to admin callers.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.Template>> GetDefaultTemplatesAsync(
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List default templates<br/>
        /// Lists the platform's default templates, ordered by template ID. Deleted templates are left out. Templates that are not public are listed only to their own team and to admin callers. The build, resources and envd version are those of the newest ready build tagged `default`, the one a sandbox started from the template runs, and are zero or empty when there is none; `buildStatus` describes the newest build tagged `default` in any state. Usage fields (`spawnCount`, `buildCount`, `lastSpawnedAt`, `createdBy`) are reported only for the caller's own templates and to admin callers.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.Template>>> GetDefaultTemplatesAsResponseAsync(
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}