
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretUpdate
    {
        /// <summary>
        /// Runtime marker stored as the secret's new version. The runtime resolves it to a value at sandbox egress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretUpdate" /> class.
        /// </summary>
        /// <param name="value">
        /// Runtime marker stored as the secret's new version. The runtime resolves it to a value at sandbox egress.
        /// </param>
        /// <param name="metadata">
        /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretUpdate(
            string value,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretUpdate" /> class.
        /// </summary>
        public SecretUpdate()
        {
        }

    }
}