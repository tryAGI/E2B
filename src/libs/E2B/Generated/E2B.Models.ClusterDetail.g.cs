
#nullable enable

namespace E2B
{
    /// <summary>
    /// A cluster's configuration. The cluster's token is never returned.
    /// </summary>
    public sealed partial class ClusterDetail
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointTls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EndpointTls { get; set; }

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
        /// While true, deleting the cluster is refused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletionProtection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DeletionProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDetail" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="endpointTls"></param>
        /// <param name="deletionProtection">
        /// While true, deleting the cluster is refused.
        /// </param>
        /// <param name="sandboxProxyDomain"></param>
        /// <param name="authOrgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterDetail(
            global::System.Guid id,
            string name,
            string endpoint,
            bool endpointTls,
            bool deletionProtection,
            string? sandboxProxyDomain,
            string? authOrgId)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.EndpointTls = endpointTls;
            this.SandboxProxyDomain = sandboxProxyDomain;
            this.AuthOrgId = authOrgId;
            this.DeletionProtection = deletionProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDetail" /> class.
        /// </summary>
        public ClusterDetail()
        {
        }

    }
}