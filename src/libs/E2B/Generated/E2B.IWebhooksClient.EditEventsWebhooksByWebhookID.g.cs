#nullable enable

namespace E2B
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update a registered webhook configuration.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.WebhookDetail> EditEventsWebhooksByWebhookIDAsync(
            global::System.Guid webhookID,

            global::E2B.WebhookConfiguration request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a registered webhook configuration.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.WebhookDetail>> EditEventsWebhooksByWebhookIDAsResponseAsync(
            global::System.Guid webhookID,

            global::E2B.WebhookConfiguration request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a registered webhook configuration.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="enabled"></param>
        /// <param name="name">
        /// Webhook user friendly name
        /// </param>
        /// <param name="url"></param>
        /// <param name="events"></param>
        /// <param name="signatureSecret">
        /// Secret used to sign the webhook payloads
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.WebhookDetail> EditEventsWebhooksByWebhookIDAsync(
            global::System.Guid webhookID,
            bool? enabled = default,
            string? name = default,
            string? url = default,
            global::System.Collections.Generic.IList<string>? events = default,
            string? signatureSecret = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}