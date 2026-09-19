#nullable enable

namespace E2B
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete a registered webhook.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEventsWebhooksByWebhookIDAsync(
            global::System.Guid webhookID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a registered webhook.
        /// </summary>
        /// <param name="webhookID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> DeleteEventsWebhooksByWebhookIDAsResponseAsync(
            global::System.Guid webhookID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}