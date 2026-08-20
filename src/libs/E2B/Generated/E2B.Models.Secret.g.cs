
#nullable enable

namespace E2B
{
    /// <summary>
    /// Metadata of a secret. It never carries the secret value.
    /// </summary>
    public sealed partial class Secret
    {
        /// <summary>
        /// Identifier of the secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretID { get; set; }

        /// <summary>
        /// Name of the secret, unique within the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version served to readers that do not name one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CurrentVersion { get; set; }

        /// <summary>
        /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Time when the secret was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the secret was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret" /> class.
        /// </summary>
        /// <param name="secretID">
        /// Identifier of the secret
        /// </param>
        /// <param name="name">
        /// Name of the secret, unique within the project
        /// </param>
        /// <param name="currentVersion">
        /// Version served to readers that do not name one
        /// </param>
        /// <param name="metadata">
        /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
        /// </param>
        /// <param name="createdAt">
        /// Time when the secret was created
        /// </param>
        /// <param name="updatedAt">
        /// Time when the secret was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Secret(
            string secretID,
            string name,
            long currentVersion,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.SecretID = secretID ?? throw new global::System.ArgumentNullException(nameof(secretID));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CurrentVersion = currentVersion;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret" /> class.
        /// </summary>
        public Secret()
        {
        }

    }
}