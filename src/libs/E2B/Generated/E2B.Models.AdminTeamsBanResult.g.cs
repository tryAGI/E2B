
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTeamsBanResult
    {
        /// <summary>
        /// Teams whose ban is stored, with the outcome of killing their sandboxes and cancelling their builds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.AdminTeamBanResult> Banned { get; set; }

        /// <summary>
        /// Requested teams that do not exist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notFound")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> NotFound { get; set; }

        /// <summary>
        /// Teams whose ban could not be stored or put into force; retrying repeats every step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.AdminTeamBanFailure> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamsBanResult" /> class.
        /// </summary>
        /// <param name="banned">
        /// Teams whose ban is stored, with the outcome of killing their sandboxes and cancelling their builds
        /// </param>
        /// <param name="notFound">
        /// Requested teams that do not exist
        /// </param>
        /// <param name="failed">
        /// Teams whose ban could not be stored or put into force; retrying repeats every step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTeamsBanResult(
            global::System.Collections.Generic.IList<global::E2B.AdminTeamBanResult> banned,
            global::System.Collections.Generic.IList<global::System.Guid> notFound,
            global::System.Collections.Generic.IList<global::E2B.AdminTeamBanFailure> failed)
        {
            this.Banned = banned ?? throw new global::System.ArgumentNullException(nameof(banned));
            this.NotFound = notFound ?? throw new global::System.ArgumentNullException(nameof(notFound));
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamsBanResult" /> class.
        /// </summary>
        public AdminTeamsBanResult()
        {
        }

    }
}