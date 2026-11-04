
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildInfo
    {
        /// <summary>
        /// Template names related to this build, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        public global::System.Collections.Generic.IList<string>? Names { get; set; }

        /// <summary>
        /// Build creation timestamp in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Build completion timestamp in RFC3339 format, if finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Build status as the builds list reports it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.BuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.BuildStatus Status { get; set; }

        /// <summary>
        /// Failure message when status is `failed`, otherwise `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildInfo" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Build creation timestamp in RFC3339 format.
        /// </param>
        /// <param name="status">
        /// Build status as the builds list reports it.
        /// </param>
        /// <param name="names">
        /// Template names related to this build, if available.
        /// </param>
        /// <param name="finishedAt">
        /// Build completion timestamp in RFC3339 format, if finished.
        /// </param>
        /// <param name="statusMessage">
        /// Failure message when status is `failed`, otherwise `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildInfo(
            global::System.DateTime createdAt,
            global::E2B.BuildStatus status,
            global::System.Collections.Generic.IList<string>? names,
            global::System.DateTime? finishedAt,
            string? statusMessage)
        {
            this.Names = names;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
            this.Status = status;
            this.StatusMessage = statusMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildInfo" /> class.
        /// </summary>
        public BuildInfo()
        {
        }

    }
}