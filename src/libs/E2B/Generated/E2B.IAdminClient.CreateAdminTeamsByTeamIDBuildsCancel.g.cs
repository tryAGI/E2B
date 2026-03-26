#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Cancel all builds for a team<br/>
        /// Cancels all in-progress and pending builds for the specified team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminBuildCancelResult> CreateAdminTeamsByTeamIDBuildsCancelAsync(
            global::System.Guid teamID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}