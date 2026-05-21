#nullable enable

namespace E2B
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get template build info
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="logsOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TemplateBuildInfo> GetTemplatesByTemplateIDBuildsByBuildIDStatusAsync(
            string templateID,
            string buildID,
            int? logsOffset = default,
            int? limit = default,
            global::E2B.LogLevel? level = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get template build info
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="logsOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TemplateBuildInfo>> GetTemplatesByTemplateIDBuildsByBuildIDStatusAsResponseAsync(
            string templateID,
            string buildID,
            int? logsOffset = default,
            int? limit = default,
            global::E2B.LogLevel? level = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}