#nullable enable

namespace E2B
{
    public partial interface IUnstableClient
    {
        /// <summary>
        /// Build details<br/>
        /// Returns a build of the team with the names of its template. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="buildID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.BuildInfo> GetUnstableBuildsByBuildIDAsync(
            string buildID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Build details<br/>
        /// Returns a build of the team with the names of its template. For E2B's own clients: it may change or disappear without notice.
        /// </summary>
        /// <param name="buildID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.BuildInfo>> GetUnstableBuildsByBuildIDAsResponseAsync(
            string buildID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}