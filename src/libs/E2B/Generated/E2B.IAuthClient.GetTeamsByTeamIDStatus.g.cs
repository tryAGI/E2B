#nullable enable

namespace E2B
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get team access status<br/>
        /// Returns whether the team is banned or blocked, and why it is blocked. A team-authenticated request may read only its own team.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TeamStatusResponse> GetTeamsByTeamIDStatusAsync(
            string teamID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get team access status<br/>
        /// Returns whether the team is banned or blocked, and why it is blocked. A team-authenticated request may read only its own team.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TeamStatusResponse>> GetTeamsByTeamIDStatusAsResponseAsync(
            string teamID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}