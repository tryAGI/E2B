
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateTagAssignment
    {
        /// <summary>
        /// Identifier of the tag assignment event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssignmentId { get; set; }

        /// <summary>
        /// Identifier of the assigned build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildId { get; set; }

        /// <summary>
        /// Time when the tag was assigned to the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Time when the assigned build was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCreatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BuildCreatedAt { get; set; }

        /// <summary>
        /// Time when the assigned build finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildFinishedAt")]
        public global::System.DateTime? BuildFinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagAssignment" /> class.
        /// </summary>
        /// <param name="assignmentId">
        /// Identifier of the tag assignment event.
        /// </param>
        /// <param name="buildId">
        /// Identifier of the assigned build.
        /// </param>
        /// <param name="assignedAt">
        /// Time when the tag was assigned to the build.
        /// </param>
        /// <param name="buildCreatedAt">
        /// Time when the assigned build was created.
        /// </param>
        /// <param name="buildFinishedAt">
        /// Time when the assigned build finished.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTagAssignment(
            global::System.Guid assignmentId,
            global::System.Guid buildId,
            global::System.DateTime assignedAt,
            global::System.DateTime buildCreatedAt,
            global::System.DateTime? buildFinishedAt)
        {
            this.AssignmentId = assignmentId;
            this.BuildId = buildId;
            this.AssignedAt = assignedAt;
            this.BuildCreatedAt = buildCreatedAt;
            this.BuildFinishedAt = buildFinishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagAssignment" /> class.
        /// </summary>
        public TemplateTagAssignment()
        {
        }

    }
}