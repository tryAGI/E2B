
#nullable enable

namespace E2B
{
    /// <summary>
    /// Webhook delivery aggregate stats
    /// </summary>
    public sealed partial class WebhookDeliveryStats
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryStatsBucket> Buckets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Failed { get; set; }

        /// <summary>
        /// Webhook delivery duration statistics in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.WebhookDeliveryDurationStats DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryStats" /> class.
        /// </summary>
        /// <param name="buckets"></param>
        /// <param name="total"></param>
        /// <param name="failed"></param>
        /// <param name="durationMs">
        /// Webhook delivery duration statistics in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveryStats(
            global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryStatsBucket> buckets,
            long total,
            long failed,
            global::E2B.WebhookDeliveryDurationStats durationMs)
        {
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
            this.Total = total;
            this.Failed = failed;
            this.DurationMs = durationMs ?? throw new global::System.ArgumentNullException(nameof(durationMs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryStats" /> class.
        /// </summary>
        public WebhookDeliveryStats()
        {
        }

    }
}