
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NodeSandbox
    {
        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TeamID { get; set; }

        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxID { get; set; }

        /// <summary>
        /// Identifier of the running execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExecutionID { get; set; }

        /// <summary>
        /// Deadline of the operation holding the sandbox's lifecycle, absent when it is not held
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycleHoldUntil")]
        public global::System.DateTime? LifecycleHoldUntil { get; set; }

        /// <summary>
        /// Network the execution runs on, legacy, egress-router or full-router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkMode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NetworkMode { get; set; }

        /// <summary>
        /// Whether the sandbox runs with managed volumes attached
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumesAttached")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VolumesAttached { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeSandbox" /> class.
        /// </summary>
        /// <param name="teamID">
        /// Identifier of the team
        /// </param>
        /// <param name="sandboxID">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="executionID">
        /// Identifier of the running execution
        /// </param>
        /// <param name="networkMode">
        /// Network the execution runs on, legacy, egress-router or full-router
        /// </param>
        /// <param name="volumesAttached">
        /// Whether the sandbox runs with managed volumes attached
        /// </param>
        /// <param name="lifecycleHoldUntil">
        /// Deadline of the operation holding the sandbox's lifecycle, absent when it is not held
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeSandbox(
            global::System.Guid teamID,
            string sandboxID,
            global::System.Guid executionID,
            string networkMode,
            bool volumesAttached,
            global::System.DateTime? lifecycleHoldUntil)
        {
            this.TeamID = teamID;
            this.SandboxID = sandboxID ?? throw new global::System.ArgumentNullException(nameof(sandboxID));
            this.ExecutionID = executionID;
            this.LifecycleHoldUntil = lifecycleHoldUntil;
            this.NetworkMode = networkMode ?? throw new global::System.ArgumentNullException(nameof(networkMode));
            this.VolumesAttached = volumesAttached;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeSandbox" /> class.
        /// </summary>
        public NodeSandbox()
        {
        }

    }
}