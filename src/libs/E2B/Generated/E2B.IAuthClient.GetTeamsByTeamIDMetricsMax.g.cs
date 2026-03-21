#nullable enable

namespace E2B
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get the maximum metrics for the team in the given interval
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="start"></param>
        /// <param name="end">
        /// Unix timestamp for the end of the interval, in seconds, for which the metrics
        /// </param>
        /// <param name="metric"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.MaxTeamMetric> GetTeamsByTeamIDMetricsMaxAsync(
            string teamID,
            global::E2B.GetTeamsMetricsMaxMetric metric,
            long? start = default,
            global::System.DateTimeOffset? end = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}