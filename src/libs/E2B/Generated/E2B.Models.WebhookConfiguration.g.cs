
#nullable enable

namespace E2B
{
    /// <summary>
    /// Configuration for updating existing webhooks
    /// </summary>
    public sealed partial class WebhookConfiguration
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Webhook user friendly name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Secret used to sign the webhook payloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatureSecret")]
        public string? SignatureSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfiguration" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="name">
        /// Webhook user friendly name
        /// </param>
        /// <param name="url"></param>
        /// <param name="events"></param>
        /// <param name="signatureSecret">
        /// Secret used to sign the webhook payloads
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfiguration(
            bool? enabled,
            string? name,
            string? url,
            global::System.Collections.Generic.IList<string>? events,
            string? signatureSecret)
        {
            this.Enabled = enabled;
            this.Name = name;
            this.Url = url;
            this.Events = events;
            this.SignatureSecret = signatureSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfiguration" /> class.
        /// </summary>
        public WebhookConfiguration()
        {
        }

    }
}