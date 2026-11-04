#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Ban teams<br/>
        /// Bans up to 100 teams at once, as<br/>
        /// `PUT /unstable/admin/teams/{teamID}/ban` does, except that every<br/>
        /// team's ban is stored before any team's sandboxes are killed or builds<br/>
        /// cancelled, and the kills and cancellations of all teams share one time<br/>
        /// budget. One team's failure does not stop the others; the response sorts<br/>
        /// every requested team into banned, not found or failed. The work<br/>
        /// continues if the caller disconnects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTeamsBanResult> AdminBanTeamsAsync(

            global::E2B.AdminTeamsBanRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ban teams<br/>
        /// Bans up to 100 teams at once, as<br/>
        /// `PUT /unstable/admin/teams/{teamID}/ban` does, except that every<br/>
        /// team's ban is stored before any team's sandboxes are killed or builds<br/>
        /// cancelled, and the kills and cancellations of all teams share one time<br/>
        /// budget. One team's failure does not stop the others; the response sorts<br/>
        /// every requested team into banned, not found or failed. The work<br/>
        /// continues if the caller disconnects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.AdminTeamsBanResult>> AdminBanTeamsAsResponseAsync(

            global::E2B.AdminTeamsBanRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ban teams<br/>
        /// Bans up to 100 teams at once, as<br/>
        /// `PUT /unstable/admin/teams/{teamID}/ban` does, except that every<br/>
        /// team's ban is stored before any team's sandboxes are killed or builds<br/>
        /// cancelled, and the kills and cancellations of all teams share one time<br/>
        /// budget. One team's failure does not stop the others; the response sorts<br/>
        /// every requested team into banned, not found or failed. The work<br/>
        /// continues if the caller disconnects.
        /// </summary>
        /// <param name="teamIDs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminTeamsBanResult> AdminBanTeamsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> teamIDs,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}