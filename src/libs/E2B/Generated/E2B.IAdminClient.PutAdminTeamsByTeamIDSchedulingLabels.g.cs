#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Replace a team's sandbox scheduling labels<br/>
        /// Replaces the labels that place the team's new sandboxes on matching<br/>
        /// nodes. Labels are deduplicated, keeping the first occurrence of each.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTeamSchedulingLabels> PutAdminTeamsByTeamIDSchedulingLabelsAsync(
            global::System.Guid teamID,

            global::E2B.AdminTeamSchedulingLabels request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a team's sandbox scheduling labels<br/>
        /// Replaces the labels that place the team's new sandboxes on matching<br/>
        /// nodes. Labels are deduplicated, keeping the first occurrence of each.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTeamSchedulingLabels>> PutAdminTeamsByTeamIDSchedulingLabelsAsResponseAsync(
            global::System.Guid teamID,

            global::E2B.AdminTeamSchedulingLabels request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a team's sandbox scheduling labels<br/>
        /// Replaces the labels that place the team's new sandboxes on matching<br/>
        /// nodes. Labels are deduplicated, keeping the first occurrence of each.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="labels">
        /// The team's full set of labels. A request's labels replace the current ones.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTeamSchedulingLabels> PutAdminTeamsByTeamIDSchedulingLabelsAsync(
            global::System.Guid teamID,
            global::System.Collections.Generic.IList<string> labels,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}