#nullable enable

namespace E2B
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// List all snapshots for the team
        /// </summary>
        /// <param name="sandboxID">
        /// Filter snapshots by source sandbox ID
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.SnapshotInfo>> GetSnapshotsAsync(
            string? sandboxID = default,
            int? limit = default,
            string? nextToken = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}