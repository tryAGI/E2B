
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildStatusItem
    {
        /// <summary>
        /// Identifier of the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Build status as the builds list reports it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.BuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.BuildStatus Status { get; set; }

        /// <summary>
        /// Build completion timestamp in RFC3339 format, if finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="BuildStatusItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the build.
        /// </param>
        /// <param name="status">
        /// Build status as the builds list reports it.
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
        public BuildStatusItem(
            global::System.Guid id,
            global::E2B.BuildStatus status,
            global::System.DateTime? finishedAt,
            string? statusMessage)
        {
            this.Id = id;
            this.Status = status;
            this.FinishedAt = finishedAt;
            this.StatusMessage = statusMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStatusItem" /> class.
        /// </summary>
        public BuildStatusItem()
        {
        }

    }
}