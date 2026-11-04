
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminSandboxBuildRestoreResult
    {
        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxID { get; set; }

        /// <summary>
        /// Identifier of the snapshot template that received the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Build that is now the template's current default build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildID { get; set; }

        /// <summary>
        /// When the new assignment was written
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Build that was current before the restore, null when there was none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousBuildID")]
        public global::System.Guid? PreviousBuildID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuildRestoreResult" /> class.
        /// </summary>
        /// <param name="sandboxID">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="templateID">
        /// Identifier of the snapshot template that received the assignment
        /// </param>
        /// <param name="buildID">
        /// Build that is now the template's current default build
        /// </param>
        /// <param name="assignedAt">
        /// When the new assignment was written
        /// </param>
        /// <param name="previousBuildID">
        /// Build that was current before the restore, null when there was none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxBuildRestoreResult(
            string sandboxID,
            string templateID,
            global::System.Guid buildID,
            global::System.DateTime assignedAt,
            global::System.Guid? previousBuildID)
        {
            this.SandboxID = sandboxID ?? throw new global::System.ArgumentNullException(nameof(sandboxID));
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.BuildID = buildID;
            this.AssignedAt = assignedAt;
            this.PreviousBuildID = previousBuildID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuildRestoreResult" /> class.
        /// </summary>
        public AdminSandboxBuildRestoreResult()
        {
        }

    }
}