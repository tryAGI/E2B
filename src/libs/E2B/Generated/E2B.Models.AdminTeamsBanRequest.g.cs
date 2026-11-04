
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTeamsBanRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamIDs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TeamIDs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamsBanRequest" /> class.
        /// </summary>
        /// <param name="teamIDs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTeamsBanRequest(
            global::System.Collections.Generic.IList<global::System.Guid> teamIDs)
        {
            this.TeamIDs = teamIDs ?? throw new global::System.ArgumentNullException(nameof(teamIDs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamsBanRequest" /> class.
        /// </summary>
        public AdminTeamsBanRequest()
        {
        }

    }
}