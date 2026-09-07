
#nullable enable

namespace E2B
{
    /// <summary>
    /// Per-domain transform rules applied to matching outbound HTTPS requests. Keys may be exact DNS names (for example, "api.example.com") or a leading wildcard (for example, "*.example.com"), and are normalized to lowercase on write. Wildcards match subdomains at any depth but not the apex domain; a bare "*" is invalid. Exact rules take precedence, followed by the longest matching wildcard suffix, and matching rule sets are not merged. Broad wildcards such as "*.com" are allowed and may expose transformed credentials to every matching destination the sandbox contacts. Rules do not grant network access; configure allowOut separately to permit the destination.
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