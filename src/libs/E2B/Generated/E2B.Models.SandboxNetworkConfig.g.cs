
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxNetworkConfig
    {
        /// <summary>
        /// Specify if the sandbox URLs should be accessible only with authentication.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowPublicTraffic")]
        public bool? AllowPublicTraffic { get; set; }

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
        /// SOCKS5 proxy for sandbox egress. Outbound TCP is tunneled through the proxy after allow/deny filtering; the sandbox is unaware. Domain-matched flows use remote DNS (ATYP=domain).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("egressProxy")]
        public global::E2B.SandboxEgressProxyConfig? EgressProxy { get; set; }

        /// <summary>
        /// Specify host mask which will be used for all sandbox requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskRequestHost")]
        public string? MaskRequestHost { get; set; }

        /// <summary>
        /// Per-domain transform rules applied to matching egress HTTP/HTTPS requests. Keys are domains (e.g. "api.example.com", "example.com"). A domain listed here is not automatically allowed - use allowOut to permit the traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkConfig" /> class.
        /// </summary>
        /// <param name="allowPublicTraffic">
        /// Specify if the sandbox URLs should be accessible only with authentication.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowOut">
        /// List of allowed destinations for egress traffic. Each entry can be a CIDR block (e.g. "8.8.8.8/32"), a bare IP address (e.g. "8.8.8.8"), or a domain name (e.g. "example.com", "*.example.com"). Allowed entries always take precedence over denied entries.
        /// </param>
        /// <param name="denyOut">
        /// List of denied CIDR blocks or IP addresses for egress traffic. Domain names are not supported for deny rules.
        /// </param>
        /// <param name="egressProxy">
        /// SOCKS5 proxy for sandbox egress. Outbound TCP is tunneled through the proxy after allow/deny filtering; the sandbox is unaware. Domain-matched flows use remote DNS (ATYP=domain).
        /// </param>
        /// <param name="maskRequestHost">
        /// Specify host mask which will be used for all sandbox requests
        /// </param>
        /// <param name="rules">
        /// Per-domain transform rules applied to matching egress HTTP/HTTPS requests. Keys are domains (e.g. "api.example.com", "example.com"). A domain listed here is not automatically allowed - use allowOut to permit the traffic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxNetworkConfig(
            bool? allowPublicTraffic,
            global::System.Collections.Generic.IList<string>? allowOut,
            global::System.Collections.Generic.IList<string>? denyOut,
            global::E2B.SandboxEgressProxyConfig? egressProxy,
            string? maskRequestHost,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? rules)
        {
            this.AllowPublicTraffic = allowPublicTraffic;
            this.AllowOut = allowOut;
            this.DenyOut = denyOut;
            this.EgressProxy = egressProxy;
            this.MaskRequestHost = maskRequestHost;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkConfig" /> class.
        /// </summary>
        public SandboxNetworkConfig()
        {
        }

    }
}