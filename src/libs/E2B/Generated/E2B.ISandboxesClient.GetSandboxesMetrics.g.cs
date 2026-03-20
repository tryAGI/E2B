#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List metrics for given sandboxes
        /// </summary>
        /// <param name="sandboxIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.SandboxesWithMetrics> GetSandboxesMetricsAsync(
            global::System.Collections.Generic.IList<string> sandboxIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}