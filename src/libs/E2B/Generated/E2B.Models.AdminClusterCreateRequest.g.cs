
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminClusterCreateRequest
    {
        /// <summary>
        /// Optional stable identifier for idempotent creation. Reuse succeeds only when the immutable configuration is identical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        public global::System.Guid? ClusterId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_tls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EndpointTls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_proxy_domain")]
        public string? SandboxProxyDomain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_org_id")]
        public string? AuthOrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClusterCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="endpointTls"></param>
        /// <param name="token"></param>
        /// <param name="clusterId">
        /// Optional stable identifier for idempotent creation. Reuse succeeds only when the immutable configuration is identical.
        /// </param>
        /// <param name="sandboxProxyDomain"></param>
        /// <param name="authOrgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminClusterCreateRequest(
            string name,
            string endpoint,
            bool endpointTls,
            string token,
            global::System.Guid? clusterId,
            string? sandboxProxyDomain,
            string? authOrgId)
        {
            this.ClusterId = clusterId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.EndpointTls = endpointTls;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.SandboxProxyDomain = sandboxProxyDomain;
            this.AuthOrgId = authOrgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClusterCreateRequest" /> class.
        /// </summary>
        public AdminClusterCreateRequest()
        {
        }

    }
}