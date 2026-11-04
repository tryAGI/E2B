#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Apply a project's block state.<br/>
        /// Records whether the project is refused billable work, which the auth path reads before it lets a sandbox start. An older or duplicate revision is accepted without changing target state. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementApplyProjectBlockAsync(
            string projectID,

            global::E2B.ManagementProjectBlockRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply a project's block state.<br/>
        /// Records whether the project is refused billable work, which the auth path reads before it lets a sandbox start. An older or duplicate revision is accepted without changing target state. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementApplyProjectBlockAsResponseAsync(
            string projectID,

            global::E2B.ManagementProjectBlockRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply a project's block state.<br/>
        /// Records whether the project is refused billable work, which the auth path reads before it lets a sandbox start. An older or duplicate revision is accepted without changing target state. Answers 404 when the project is missing or deleted.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="revision">
        /// Monotonic per-project revision. Older or duplicate revisions succeed without changing stored state.
        /// </param>
        /// <param name="blocked">
        /// Whether the project is refused billable work.
        /// </param>
        /// <param name="reason">
        /// Reason included in blocked-request errors. Cleared when blocked is false.
        /// </param>
        /// <param name="decidedAt">
        /// When the caller decided this revision, in RFC 3339. Stored with the revision and used to measure how long the decision took to apply here. Omit it when the caller does not know; the delivery is then counted as origin unknown rather than as zero lag.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ManagementApplyProjectBlockAsync(
            string projectID,
            long revision,
            bool blocked,
            string? reason = default,
            global::System.DateTime? decidedAt = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}