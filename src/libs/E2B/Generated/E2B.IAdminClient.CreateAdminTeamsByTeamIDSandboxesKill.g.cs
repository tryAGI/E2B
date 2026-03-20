#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Kill all sandboxes for a team<br/>
        /// Kills all sandboxes for the specified team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AdminSandboxKillResult> CreateAdminTeamsByTeamIDSandboxesKillAsync(
            global::System.Guid teamID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}