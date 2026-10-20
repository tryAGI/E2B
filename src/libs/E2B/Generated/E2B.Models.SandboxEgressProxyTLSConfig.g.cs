
#nullable enable

namespace E2B
{
    /// <summary>
    /// TLS for the connection to the SOCKS5 proxy. The SOCKS5 negotiation and the tunneled traffic both run inside the TLS session, so the proxy credentials are not sent in the clear. This secures only the hop to the proxy; what the proxy does onward is its own concern. A half-close from the sandbox reaches the proxy as a TLS close_notify, not a TCP FIN, and a proxy that treats close_notify as a full close cuts the reply short.
    /// </summary>
    public sealed partial class SandboxEgressProxyTLSConfig
    {
        /// <summary>
        /// Connect to the proxy over TLS. When false, no other field in this object may be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Name to verify the proxy certificate against, and to send as SNI. Defaults to the host part of address. Set this only when the certificate does not match the address the proxy is reached at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverName")]
        public string? ServerName { get; set; }

        /// <summary>
        /// One or more PEM-encoded certificates to verify the proxy against, for a proxy fronted by a private CA. These replace the system trust store, which is what is used when this is omitted. The system trust store depends on the host the orchestrator runs on, so set this to get the same verification everywhere.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caCert")]
        public string? CaCert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEgressProxyTLSConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Connect to the proxy over TLS. When false, no other field in this object may be set.
        /// </param>
        /// <param name="serverName">
        /// Name to verify the proxy certificate against, and to send as SNI. Defaults to the host part of address. Set this only when the certificate does not match the address the proxy is reached at.
        /// </param>
        /// <param name="caCert">
        /// One or more PEM-encoded certificates to verify the proxy against, for a proxy fronted by a private CA. These replace the system trust store, which is what is used when this is omitted. The system trust store depends on the host the orchestrator runs on, so set this to get the same verification everywhere.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxEgressProxyTLSConfig(
            bool enabled,
            string? serverName,
            string? caCert)
        {
            this.Enabled = enabled;
            this.ServerName = serverName;
            this.CaCert = caCert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEgressProxyTLSConfig" /> class.
        /// </summary>
        public SandboxEgressProxyTLSConfig()
        {
        }

    }
}