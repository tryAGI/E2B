
#nullable enable

namespace E2B
{
    /// <summary>
    /// The sandboxes the API confirms are running on a node, as the node and the API's records agree on them when read. A guest the node runs for an execution the API records elsewhere, or does not record, is left out.
    /// </summary>
    public sealed partial class NodeSandboxes
    {
        /// <summary>
        /// Identifier of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeID { get; set; }

        /// <summary>
        /// Time the node's sandboxes were read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ObservedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.NodeSandbox> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeSandboxes" /> class.
        /// </summary>
        /// <param name="nodeID">
        /// Identifier of the node
        /// </param>
        /// <param name="observedAt">
        /// Time the node's sandboxes were read
        /// </param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeSandboxes(
            string nodeID,
            global::System.DateTime observedAt,
            global::System.Collections.Generic.IList<global::E2B.NodeSandbox> items)
        {
            this.NodeID = nodeID ?? throw new global::System.ArgumentNullException(nameof(nodeID));
            this.ObservedAt = observedAt;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeSandboxes" /> class.
        /// </summary>
        public NodeSandboxes()
        {
        }

    }
}