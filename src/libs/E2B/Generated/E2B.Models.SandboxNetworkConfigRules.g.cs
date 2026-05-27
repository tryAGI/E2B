
#nullable enable

namespace E2B
{
    /// <summary>
    /// Per-domain transform rules applied to matching egress HTTP/HTTPS requests. Keys are domains (e.g. "api.example.com", "example.com"). A domain listed here is not automatically allowed - use allowOut to permit the traffic.
    /// </summary>
    public sealed partial class SandboxNetworkConfigRules
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}