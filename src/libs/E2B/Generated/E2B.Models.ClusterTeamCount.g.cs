
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClusterTeamCount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ClusterId { get; set; }

        /// <summary>
        /// Number of live teams assigned to the cluster
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
        /// Initializes a new instance of the <see cref="ClusterTeamCount" /> class.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="teamCount">
        /// Number of live teams assigned to the cluster
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterTeamCount(
            global::System.Guid clusterId,
            long teamCount)
        {
            this.ClusterId = clusterId;
            this.TeamCount = teamCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTeamCount" /> class.
        /// </summary>
        public ClusterTeamCount()
        {
        }

    }
}