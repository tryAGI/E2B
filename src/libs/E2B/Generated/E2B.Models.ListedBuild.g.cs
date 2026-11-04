
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListedBuild
    {
        /// <summary>
        /// Identifier of the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Template alias when present, otherwise template ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Identifier of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

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
        /// CPU cores configured for the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CpuCount { get; set; }

        /// <summary>
        /// Memory in MiB configured for the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MemoryMB { get; set; }

        /// <summary>
        /// Disk size in MiB configured for the build, if recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskSizeMB")]
        public long? DiskSizeMB { get; set; }

        /// <summary>
        /// envd version the build was created with, if recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdVersion")]
        public string? EnvdVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListedBuild" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the build.
        /// </param>
        /// <param name="template">
        /// Template alias when present, otherwise template ID.
        /// </param>
        /// <param name="templateId">
        /// Identifier of the template.
        /// </param>
        /// <param name="status">
        /// Build status as the builds list reports it.
        /// </param>
        /// <param name="createdAt">
        /// Build creation timestamp in RFC3339 format.
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores configured for the build.
        /// </param>
        /// <param name="memoryMB">
        /// Memory in MiB configured for the build.
        /// </param>
        /// <param name="statusMessage">
        /// Failure message when status is `failed`, otherwise `null`.
        /// </param>
        /// <param name="finishedAt">
        /// Build completion timestamp in RFC3339 format, if finished.
        /// </param>
        /// <param name="diskSizeMB">
        /// Disk size in MiB configured for the build, if recorded.
        /// </param>
        /// <param name="envdVersion">
        /// envd version the build was created with, if recorded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListedBuild(
            global::System.Guid id,
            string template,
            string templateId,
            global::E2B.BuildStatus status,
            global::System.DateTime createdAt,
            long cpuCount,
            long memoryMB,
            string? statusMessage,
            global::System.DateTime? finishedAt,
            long? diskSizeMB,
            string? envdVersion)
        {
            this.Id = id;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
            this.DiskSizeMB = diskSizeMB;
            this.EnvdVersion = envdVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListedBuild" /> class.
        /// </summary>
        public ListedBuild()
        {
        }

    }
}