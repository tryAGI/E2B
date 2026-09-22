
#nullable enable

namespace E2B
{
    /// <summary>
    /// Configuration for registering new webhooks
    /// </summary>
    public sealed partial class WebhookCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Secret used to sign the webhook payloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatureSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignatureSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="events"></param>
        /// <param name="signatureSecret">
        /// Secret used to sign the webhook payloads
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCreate(
            string name,
            string url,
            global::System.Collections.Generic.IList<string> events,
            string signatureSecret,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Enabled = enabled;
            this.SignatureSecret = signatureSecret ?? throw new global::System.ArgumentNullException(nameof(signatureSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCreate" /> class.
        /// </summary>
        public WebhookCreate()
        {
        }

    }
}