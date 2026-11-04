
#nullable enable

namespace E2B
{
    /// <summary>
    /// Desired project ban state. A newer revision replaces the state, including any intervening manual ban or unban.
    /// </summary>
    public sealed partial class ManagementProjectBanRequest
    {
        /// <summary>
        /// Monotonic per-project revision. Older or duplicate revisions succeed without changing stored state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Revision { get; set; }

        /// <summary>
        /// Whether the project is refused at authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Banned { get; set; }

        /// <summary>
        /// When the caller decided this revision, in RFC 3339. Stored with the revision and used to measure how long the decision took to apply here. Omit it when the caller does not know; the delivery is then counted as origin unknown rather than as zero lag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decided_at")]
        public global::System.DateTime? DecidedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectBanRequest" /> class.
        /// </summary>
        /// <param name="revision">
        /// Monotonic per-project revision. Older or duplicate revisions succeed without changing stored state.
        /// </param>
        /// <param name="banned">
        /// Whether the project is refused at authentication.
        /// </param>
        /// <param name="decidedAt">
        /// When the caller decided this revision, in RFC 3339. Stored with the revision and used to measure how long the decision took to apply here. Omit it when the caller does not know; the delivery is then counted as origin unknown rather than as zero lag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectBanRequest(
            long revision,
            bool banned,
            global::System.DateTime? decidedAt)
        {
            this.Revision = revision;
            this.Banned = banned;
            this.DecidedAt = decidedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectBanRequest" /> class.
        /// </summary>
        public ManagementProjectBanRequest()
        {
        }

    }
}