
#nullable enable

namespace E2B
{
    /// <summary>
    /// SOCKS5 proxy for sandbox egress. Outbound TCP is tunneled through the proxy after allow/deny filtering; the sandbox is unaware. Domain-matched flows use remote DNS (ATYP=domain).
    /// </summary>
    public sealed partial class SandboxEgressProxyConfig
    {
        /// <summary>
        /// SOCKS5 proxy address in host:port format (e.g. "proxy.example.com:1080").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Optional SOCKS5 username (RFC 1929), max 255 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Optional SOCKS5 password (RFC 1929), max 255 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEgressProxyConfig" /> class.
        /// </summary>
        /// <param name="address">
        /// SOCKS5 proxy address in host:port format (e.g. "proxy.example.com:1080").
        /// </param>
        /// <param name="username">
        /// Optional SOCKS5 username (RFC 1929), max 255 bytes.
        /// </param>
        /// <param name="password">
        /// Optional SOCKS5 password (RFC 1929), max 255 bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxEgressProxyConfig(
            string address,
            string? username,
            string? password)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEgressProxyConfig" /> class.
        /// </summary>
        public SandboxEgressProxyConfig()
        {
        }

    }
}