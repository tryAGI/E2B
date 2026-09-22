
#nullable enable

namespace E2B
{
    /// <summary>
    /// Webhook delivery duration statistics in milliseconds
    /// </summary>
    public sealed partial class WebhookDeliveryDurationStats
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Minimum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Average { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Maximum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryDurationStats" /> class.
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="average"></param>
        /// <param name="maximum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveryDurationStats(
            double minimum,
            double average,
            double maximum)
        {
            this.Minimum = minimum;
            this.Average = average;
            this.Maximum = maximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryDurationStats" /> class.
        /// </summary>
        public WebhookDeliveryDurationStats()
        {
        }

    }
}