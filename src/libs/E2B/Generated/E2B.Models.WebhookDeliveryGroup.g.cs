
#nullable enable

namespace E2B
{
    /// <summary>
    /// Webhook delivery attempts grouped by sandbox event
    /// </summary>
    public sealed partial class WebhookDeliveryGroup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.WebhookDelivery> Attempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryGroup" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="eventType"></param>
        /// <param name="sandboxId"></param>
        /// <param name="attempts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveryGroup(
            global::System.Guid eventId,
            string eventType,
            string sandboxId,
            global::System.Collections.Generic.IList<global::E2B.WebhookDelivery> attempts)
        {
            this.EventId = eventId;
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.SandboxId = sandboxId ?? throw new global::System.ArgumentNullException(nameof(sandboxId));
            this.Attempts = attempts ?? throw new global::System.ArgumentNullException(nameof(attempts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryGroup" /> class.
        /// </summary>
        public WebhookDeliveryGroup()
        {
        }

    }
}