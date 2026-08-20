
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewSecret
    {
        /// <summary>
        /// Name of the secret, unique within the project. Names are lower-cased before storage and returned in that canonical form; the sec_ prefix is reserved for secret identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Runtime marker stored as the secret's first version. The runtime resolves it to a value at sandbox egress.
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
        /// Initializes a new instance of the <see cref="NewSecret" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the secret, unique within the project. Names are lower-cased before storage and returned in that canonical form; the sec_ prefix is reserved for secret identifiers.
        /// </param>
        /// <param name="value">
        /// Runtime marker stored as the secret's first version. The runtime resolves it to a value at sandbox egress.
        /// </param>
        /// <param name="metadata">
        /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewSecret(
            string name,
            string value,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewSecret" /> class.
        /// </summary>
        public NewSecret()
        {
        }

    }
}