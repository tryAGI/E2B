#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox logs
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="direction">
        /// Direction of the logs that should be returned
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.SandboxLogsV2Response> GetSandboxesBySandboxIDLogs2Async(
            string sandboxID,
            long? cursor = default,
            int? limit = default,
            global::E2B.LogsDirection? direction = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}