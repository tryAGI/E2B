#nullable enable

namespace E2B
{
    public partial interface IUnstableClient
    {
        /// <summary>
        /// Build statuses<br/>
        /// Returns the statuses of the team's builds with the given IDs; IDs of other teams' builds are left out. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="buildIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.BuildsStatusesResponse> GetUnstableBuildsStatusesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> buildIds,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Build statuses<br/>
        /// Returns the statuses of the team's builds with the given IDs; IDs of other teams' builds are left out. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="buildIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.BuildsStatusesResponse>> GetUnstableBuildsStatusesAsResponseAsync(
            global::System.Collections.Generic.IList<global::System.Guid> buildIds,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}