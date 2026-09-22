#nullable enable

namespace E2B
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook delivery aggregate stats.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.WebhookDeliveryStats> GetEventsWebhooksByWebhookIDStatsAsync(
            global::System.Guid webhookID,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhook delivery aggregate stats.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.WebhookDeliveryStats>> GetEventsWebhooksByWebhookIDStatsAsResponseAsync(
            global::System.Guid webhookID,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}