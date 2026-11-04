
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClusterListItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxProxyDomain")]
        public string? SandboxProxyDomain { get; set; }

        /// <summary>
        /// Number of teams assigned to the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TeamCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="teamCount">
        /// Number of teams assigned to the cluster.
        /// </param>
        /// <param name="sandboxProxyDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterListItem(
            global::System.Guid id,
            string name,
            string endpoint,
            long teamCount,
            string? sandboxProxyDomain)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.SandboxProxyDomain = sandboxProxyDomain;
            this.TeamCount = teamCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterListItem" /> class.
        /// </summary>
        public ClusterListItem()
        {
        }

    }
}