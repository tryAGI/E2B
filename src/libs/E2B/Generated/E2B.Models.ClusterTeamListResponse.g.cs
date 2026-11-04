
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClusterTeamListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.ClusterTeamListItem> Items { get; set; }

        /// <summary>
        /// Number of teams assigned to the cluster, ignoring limit and offset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTeamListResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="total">
        /// Number of teams assigned to the cluster, ignoring limit and offset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterTeamListResponse(
            global::System.Collections.Generic.IList<global::E2B.ClusterTeamListItem> items,
            long total)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTeamListResponse" /> class.
        /// </summary>
        public ClusterTeamListResponse()
        {
        }

    }
}