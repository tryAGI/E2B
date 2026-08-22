
#nullable enable

namespace E2B
{
    /// <summary>
    /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
    /// </summary>
    public sealed partial class SecretMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}