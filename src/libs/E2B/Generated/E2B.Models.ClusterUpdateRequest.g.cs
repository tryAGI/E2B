
#nullable enable

namespace E2B
{
    /// <summary>
    /// Partial update; only the properties present are written. An explicit null or an empty string clears `sandboxProxyDomain` or `authOrgId`.
    /// </summary>
    public sealed partial class ClusterUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointTls")]
        public bool? EndpointTls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxProxyDomain")]
        public string? SandboxProxyDomain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authOrgId")]
        public string? AuthOrgId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="endpointTls"></param>
        /// <param name="sandboxProxyDomain"></param>
        /// <param name="authOrgId"></param>
        /// <param name="deletionProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterUpdateRequest(
            string? name,
            string? endpoint,
            bool? endpointTls,
            string? sandboxProxyDomain,
            string? authOrgId,
            bool? deletionProtection)
        {
            this.Name = name;
            this.Endpoint = endpoint;
            this.EndpointTls = endpointTls;
            this.SandboxProxyDomain = sandboxProxyDomain;
            this.AuthOrgId = authOrgId;
            this.DeletionProtection = deletionProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterUpdateRequest" /> class.
        /// </summary>
        public ClusterUpdateRequest()
        {
        }

    }
}