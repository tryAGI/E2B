#nullable enable

namespace E2B
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List webhook delivery attempts.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="orderAsc">
        /// Default Value: false
        /// </param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="deliveryStatus"></param>
        /// <param name="eventType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.WebhookDeliveriesListPayload> GetEventsWebhooksByWebhookIDDeliveriesAsync(
            global::System.Guid webhookID,
            string? cursor = default,
            int? limit = default,
            bool? orderAsc = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::System.Collections.Generic.IList<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? deliveryStatus = default,
            global::System.Collections.Generic.IList<string>? eventType = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook delivery attempts.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="orderAsc">
        /// Default Value: false
        /// </param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="deliveryStatus"></param>
        /// <param name="eventType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.WebhookDeliveriesListPayload>> GetEventsWebhooksByWebhookIDDeliveriesAsResponseAsync(
            global::System.Guid webhookID,
            string? cursor = default,
            int? limit = default,
            bool? orderAsc = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::System.Collections.Generic.IList<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? deliveryStatus = default,
            global::System.Collections.Generic.IList<string>? eventType = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}