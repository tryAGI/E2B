
#nullable enable

namespace E2B
{
    /// <summary>
    /// Network configuration update for a running sandbox. Replaces the current egress rules with the provided configuration. Omitting a field clears it.
    /// </summary>
    public sealed partial class SandboxNetworkUpdateConfig
    {
        /// <summary>
        /// List of allowed destinations for egress traffic. Each entry can be a CIDR block (e.g. "8.8.8.8/32"), a bare IP address (e.g. "8.8.8.8"), or a domain name (e.g. "example.com", "*.example.com"). Allowed entries always take precedence over denied entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowOut")]
        public global::System.Collections.Generic.IList<string>? AllowOut { get; set; }

        /// <summary>
        /// List of denied CIDR blocks or IP addresses for egress traffic. Domain names are not supported for deny rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denyOut")]
        public global::System.Collections.Generic.IList<string>? DenyOut { get; set; }

        /// <summary>
        /// Per-domain transform rules. Replaces all existing rules when provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? Rules { get; set; }

        /// <summary>
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_internet_access")]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkUpdateConfig" /> class.
        /// </summary>
        /// <param name="allowOut">
        /// List of allowed destinations for egress traffic. Each entry can be a CIDR block (e.g. "8.8.8.8/32"), a bare IP address (e.g. "8.8.8.8"), or a domain name (e.g. "example.com", "*.example.com"). Allowed entries always take precedence over denied entries.
        /// </param>
        /// <param name="denyOut">
        /// List of denied CIDR blocks or IP addresses for egress traffic. Domain names are not supported for deny rules.
        /// </param>
        /// <param name="rules">
        /// Per-domain transform rules. Replaces all existing rules when provided.
        /// </param>
        /// <param name="allowInternetAccess">
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxNetworkUpdateConfig(
            global::System.Collections.Generic.IList<string>? allowOut,
            global::System.Collections.Generic.IList<string>? denyOut,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? rules,
            bool? allowInternetAccess)
        {
            this.AllowOut = allowOut;
            this.DenyOut = denyOut;
            this.Rules = rules;
            this.AllowInternetAccess = allowInternetAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkUpdateConfig" /> class.
        /// </summary>
        public SandboxNetworkUpdateConfig()
        {
        }

    }
}