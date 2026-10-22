
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamStatusResponse
    {
        /// <summary>
        /// Whether the team is banned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBanned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBanned { get; set; }

        /// <summary>
        /// Whether the team is blocked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBlocked { get; set; }

        /// <summary>
        /// Why the team is blocked, if a reason was recorded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedReason")]
        public string? BlockedReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStatusResponse" /> class.
        /// </summary>
        /// <param name="isBanned">
        /// Whether the team is banned
        /// </param>
        /// <param name="isBlocked">
        /// Whether the team is blocked
        /// </param>
        /// <param name="blockedReason">
        /// Why the team is blocked, if a reason was recorded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamStatusResponse(
            bool isBanned,
            bool isBlocked,
            string? blockedReason)
        {
            this.IsBanned = isBanned;
            this.IsBlocked = isBlocked;
            this.BlockedReason = blockedReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStatusResponse" /> class.
        /// </summary>
        public TeamStatusResponse()
        {
        }

    }
}