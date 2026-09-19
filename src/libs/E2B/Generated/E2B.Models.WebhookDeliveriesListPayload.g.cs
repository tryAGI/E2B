
#nullable enable

namespace E2B
{
    /// <summary>
    /// Paginated webhook delivery attempts grouped by event
    /// </summary>
    public sealed partial class WebhookDeliveriesListPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryGroup> Data { get; set; }

        /// <summary>
        /// Cursor to pass to the next list request, or null when there is no next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveriesListPayload" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextCursor">
        /// Cursor to pass to the next list request, or null when there is no next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveriesListPayload(
            global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryGroup> data,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveriesListPayload" /> class.
        /// </summary>
        public WebhookDeliveriesListPayload()
        {
        }

    }
}