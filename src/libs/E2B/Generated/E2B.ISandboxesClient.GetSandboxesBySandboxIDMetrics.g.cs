#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox metrics
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="start"></param>
        /// <param name="end">
        /// Unix timestamp for the end of the interval, in seconds, for which the metrics
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.SandboxMetric>> GetSandboxesBySandboxIDMetricsAsync(
            string sandboxID,
            long? start = default,
            global::System.DateTimeOffset? end = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}