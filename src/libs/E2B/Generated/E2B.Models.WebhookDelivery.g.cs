
#nullable enable

namespace E2B
{
    /// <summary>
    /// Webhook delivery attempt
    /// </summary>
    public sealed partial class WebhookDelivery
    {
        /// <summary>
        /// Delivery attempt identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Team identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TeamId { get; set; }

        /// <summary>
        /// Webhook configuration identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WebhookId { get; set; }

        /// <summary>
        /// Sandbox event identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EventId { get; set; }

        /// <summary>
        /// Sandbox identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxId { get; set; }

        /// <summary>
        /// Sandbox event type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        /// Delivery attempt status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.WebhookDeliveryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.WebhookDeliveryStatus Status { get; set; }

        /// <summary>
        /// Delivery request duration in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// Serialized webhook request body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestBody { get; set; }

        /// <summary>
        /// JSON-encoded request headers with sensitive values redacted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestHeaders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestHeaders { get; set; }

        /// <summary>
        /// URL attempted for this delivery
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestUrl { get; set; }

        /// <summary>
        /// Truncated response body, if a response was received
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBody")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// JSON-encoded response headers, if a response was received
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseHeaders")]
        public string? ResponseHeaders { get; set; }

        /// <summary>
        /// HTTP response status code, if a response was received
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseHttpStatusCode")]
        public int? ResponseHttpStatusCode { get; set; }

        /// <summary>
        /// Machine-readable non-HTTP or HTTP failure class
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorClass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.WebhookDeliveryErrorClassJsonConverter))]
        public global::E2B.WebhookDeliveryErrorClass? ErrorClass { get; set; }

        /// <summary>
        /// Error message for failures without a useful response body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Time when the delivery attempt started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDelivery" /> class.
        /// </summary>
        /// <param name="id">
        /// Delivery attempt identifier
        /// </param>
        /// <param name="teamId">
        /// Team identifier
        /// </param>
        /// <param name="webhookId">
        /// Webhook configuration identifier
        /// </param>
        /// <param name="eventId">
        /// Sandbox event identifier
        /// </param>
        /// <param name="sandboxId">
        /// Sandbox identifier
        /// </param>
        /// <param name="eventType">
        /// Sandbox event type
        /// </param>
        /// <param name="status">
        /// Delivery attempt status
        /// </param>
        /// <param name="durationMs">
        /// Delivery request duration in milliseconds
        /// </param>
        /// <param name="requestBody">
        /// Serialized webhook request body
        /// </param>
        /// <param name="requestHeaders">
        /// JSON-encoded request headers with sensitive values redacted
        /// </param>
        /// <param name="requestUrl">
        /// URL attempted for this delivery
        /// </param>
        /// <param name="timestamp">
        /// Time when the delivery attempt started
        /// </param>
        /// <param name="responseBody">
        /// Truncated response body, if a response was received
        /// </param>
        /// <param name="responseHeaders">
        /// JSON-encoded response headers, if a response was received
        /// </param>
        /// <param name="responseHttpStatusCode">
        /// HTTP response status code, if a response was received
        /// </param>
        /// <param name="errorClass">
        /// Machine-readable non-HTTP or HTTP failure class
        /// </param>
        /// <param name="errorMessage">
        /// Error message for failures without a useful response body
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDelivery(
            global::System.Guid id,
            global::System.Guid teamId,
            global::System.Guid webhookId,
            global::System.Guid eventId,
            string sandboxId,
            string eventType,
            global::E2B.WebhookDeliveryStatus status,
            int durationMs,
            string requestBody,
            string requestHeaders,
            string requestUrl,
            global::System.DateTime timestamp,
            string? responseBody,
            string? responseHeaders,
            int? responseHttpStatusCode,
            global::E2B.WebhookDeliveryErrorClass? errorClass,
            string? errorMessage)
        {
            this.Id = id;
            this.TeamId = teamId;
            this.WebhookId = webhookId;
            this.EventId = eventId;
            this.SandboxId = sandboxId ?? throw new global::System.ArgumentNullException(nameof(sandboxId));
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Status = status;
            this.DurationMs = durationMs;
            this.RequestBody = requestBody ?? throw new global::System.ArgumentNullException(nameof(requestBody));
            this.RequestHeaders = requestHeaders ?? throw new global::System.ArgumentNullException(nameof(requestHeaders));
            this.RequestUrl = requestUrl ?? throw new global::System.ArgumentNullException(nameof(requestUrl));
            this.ResponseBody = responseBody;
            this.ResponseHeaders = responseHeaders;
            this.ResponseHttpStatusCode = responseHttpStatusCode;
            this.ErrorClass = errorClass;
            this.ErrorMessage = errorMessage;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDelivery" /> class.
        /// </summary>
        public WebhookDelivery()
        {
        }

    }
}