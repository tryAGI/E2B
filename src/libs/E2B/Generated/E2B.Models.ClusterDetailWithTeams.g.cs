
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClusterDetailWithTeams
    {
        /// <summary>
        /// A cluster's configuration. The cluster's token is never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.ClusterDetail Cluster { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.ClusterTeamListResponse Teams { get; set; }

        /// <summary>
        /// Teams assigned to the cluster. Must be 0 before the cluster can be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TeamCount { get; set; }

        /// <summary>
        /// Live templates on the cluster. Deleting the cluster deletes them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TemplateCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDetailWithTeams" /> class.
        /// </summary>
        /// <param name="cluster">
        /// A cluster's configuration. The cluster's token is never returned.
        /// </param>
        /// <param name="teams"></param>
        /// <param name="teamCount">
        /// Teams assigned to the cluster. Must be 0 before the cluster can be deleted.
        /// </param>
        /// <param name="templateCount">
        /// Live templates on the cluster. Deleting the cluster deletes them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterDetailWithTeams(
            global::E2B.ClusterDetail cluster,
            global::E2B.ClusterTeamListResponse teams,
            long teamCount,
            long templateCount)
        {
            this.Cluster = cluster ?? throw new global::System.ArgumentNullException(nameof(cluster));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.TeamCount = teamCount;
            this.TemplateCount = templateCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDetailWithTeams" /> class.
        /// </summary>
        public ClusterDetailWithTeams()
        {
        }

    }
}