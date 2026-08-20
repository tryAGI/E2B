#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List sandboxes (v2)<br/>
        /// List all sandboxes
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="state"></param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="startedAfter"></param>
        /// <param name="template"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.ListedSandbox>> GetSandboxes2Async(
            string? metadata = default,
            global::System.Collections.Generic.IList<global::E2B.SandboxState>? state = default,
            global::E2B.OrderDirection? order = default,
            global::System.DateTime? startedAfter = default,
            string? template = default,
            string? nextToken = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List sandboxes (v2)<br/>
        /// List all sandboxes
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="state"></param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="startedAfter"></param>
        /// <param name="template"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.ListedSandbox>>> GetSandboxes2AsResponseAsync(
            string? metadata = default,
            global::System.Collections.Generic.IList<global::E2B.SandboxState>? state = default,
            global::E2B.OrderDirection? order = default,
            global::System.DateTime? startedAfter = default,
            string? template = default,
            string? nextToken = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}