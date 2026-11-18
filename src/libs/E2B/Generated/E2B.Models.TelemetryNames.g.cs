
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TelemetryNames
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::E2B.TelemetryTeamName> Teams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.TelemetryClusterName> Clusters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryNames" /> class.
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="clusters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryNames(
            global::System.Collections.Generic.Dictionary<string, global::E2B.TelemetryTeamName> teams,
            global::System.Collections.Generic.IList<global::E2B.TelemetryClusterName> clusters)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Clusters = clusters ?? throw new global::System.ArgumentNullException(nameof(clusters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryNames" /> class.
        /// </summary>
        public TelemetryNames()
        {
        }

    }
}