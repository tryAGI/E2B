#nullable enable

namespace E2B
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Register events webhook.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.WebhookCreation> CreateEventsWebhooksAsync(

            global::E2B.WebhookCreate request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register events webhook.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.WebhookCreation>> CreateEventsWebhooksAsResponseAsync(

            global::E2B.WebhookCreate request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register events webhook.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="events"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="signatureSecret">
        /// Secret used to sign the webhook payloads
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.WebhookCreation> CreateEventsWebhooksAsync(
            string name,
            string url,
            global::System.Collections.Generic.IList<string> events,
            string signatureSecret,
            bool? enabled = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}