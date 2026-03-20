#nullable enable

namespace E2B
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// List all teams
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.Team>> GetTeamsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}