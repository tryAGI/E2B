#nullable enable

namespace E2B
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get team limits<br/>
        /// Returns the team's effective resource limits. A team-authenticated request may read only its own team.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TeamLimitsResponse> GetTeamsByTeamIDLimitsAsync(
            string teamID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get team limits<br/>
        /// Returns the team's effective resource limits. A team-authenticated request may read only its own team.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TeamLimitsResponse>> GetTeamsByTeamIDLimitsAsResponseAsync(
            string teamID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}