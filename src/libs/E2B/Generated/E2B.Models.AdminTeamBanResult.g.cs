
#nullable enable

namespace E2B
{
    /// <summary>
    /// The outcome of banning one team. The ban is stored before the team's<br/>
    /// sandboxes are killed and its builds cancelled, so it holds even when<br/>
    /// either step fails.
    /// </summary>
    public sealed partial class AdminTeamBanResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TeamID { get; set; }

        /// <summary>
        /// Number of the team's sandboxes killed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxesKilled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SandboxesKilled { get; set; }

        /// <summary>
        /// Number of the team's sandboxes that failed to kill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxesFailedToKill")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SandboxesFailedToKill { get; set; }

        /// <summary>
        /// Set when the kill step failed or ran out of time; the counts cover what it did until then.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxKillError")]
        public string? SandboxKillError { get; set; }

        /// <summary>
        /// Number of the team's builds cancelled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsCancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BuildsCancelled { get; set; }

        /// <summary>
        /// Number of the team's builds that failed to cancel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsFailedToCancel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BuildsFailedToCancel { get; set; }

        /// <summary>
        /// Set when the cancel step failed or ran out of time; the counts cover what it did until then.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCancelError")]
        public string? BuildCancelError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamBanResult" /> class.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="sandboxesKilled">
        /// Number of the team's sandboxes killed
        /// </param>
        /// <param name="sandboxesFailedToKill">
        /// Number of the team's sandboxes that failed to kill
        /// </param>
        /// <param name="buildsCancelled">
        /// Number of the team's builds cancelled
        /// </param>
        /// <param name="buildsFailedToCancel">
        /// Number of the team's builds that failed to cancel
        /// </param>
        /// <param name="sandboxKillError">
        /// Set when the kill step failed or ran out of time; the counts cover what it did until then.
        /// </param>
        /// <param name="buildCancelError">
        /// Set when the cancel step failed or ran out of time; the counts cover what it did until then.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTeamBanResult(
            global::System.Guid teamID,
            int sandboxesKilled,
            int sandboxesFailedToKill,
            int buildsCancelled,
            int buildsFailedToCancel,
            string? sandboxKillError,
            string? buildCancelError)
        {
            this.TeamID = teamID;
            this.SandboxesKilled = sandboxesKilled;
            this.SandboxesFailedToKill = sandboxesFailedToKill;
            this.SandboxKillError = sandboxKillError;
            this.BuildsCancelled = buildsCancelled;
            this.BuildsFailedToCancel = buildsFailedToCancel;
            this.BuildCancelError = buildCancelError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamBanResult" /> class.
        /// </summary>
        public AdminTeamBanResult()
        {
        }

    }
}