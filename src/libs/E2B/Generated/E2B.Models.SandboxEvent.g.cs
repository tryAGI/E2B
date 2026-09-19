
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace E2B
{
    /// <summary>
    /// Sandbox event
    /// </summary>
    public sealed partial class SandboxEvent
    {
        /// <summary>
        /// Event unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Event structure version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Category of the event (e.g., 'lifecycle', 'process', etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventCategory")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EventCategory { get; set; }

        /// <summary>
        /// Label for the specific event type (e.g., 'sandbox_started', 'process_oom', etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventLabel")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EventLabel { get; set; }

        /// <summary>
        /// Optional JSON data associated with the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventData")]
        public object? EventData { get; set; }

        /// <summary>
        /// Timestamp of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Unique identifier for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxId { get; set; }

        /// <summary>
        /// Unique identifier for the sandbox execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxExecutionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxExecutionId { get; set; }

        /// <summary>
        /// Unique identifier for the sandbox template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxTemplateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxTemplateId { get; set; }

        /// <summary>
        /// Unique identifier for the sandbox build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxBuildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxBuildId { get; set; }

        /// <summary>
        /// Team identifier associated with the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxTeamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SandboxTeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Event unique identifier
        /// </param>
        /// <param name="version">
        /// Event structure version
        /// </param>
        /// <param name="type">
        /// Event name
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of the event
        /// </param>
        /// <param name="sandboxId">
        /// Unique identifier for the sandbox
        /// </param>
        /// <param name="sandboxExecutionId">
        /// Unique identifier for the sandbox execution
        /// </param>
        /// <param name="sandboxTemplateId">
        /// Unique identifier for the sandbox template
        /// </param>
        /// <param name="sandboxBuildId">
        /// Unique identifier for the sandbox build
        /// </param>
        /// <param name="sandboxTeamId">
        /// Team identifier associated with the sandbox
        /// </param>
        /// <param name="eventData">
        /// Optional JSON data associated with the event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxEvent(
            global::System.Guid id,
            string version,
            string type,
            global::System.DateTime timestamp,
            string sandboxId,
            string sandboxExecutionId,
            string sandboxTemplateId,
            string sandboxBuildId,
            global::System.Guid sandboxTeamId,
            object? eventData)
        {
            this.Id = id;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.EventData = eventData;
            this.Timestamp = timestamp;
            this.SandboxId = sandboxId ?? throw new global::System.ArgumentNullException(nameof(sandboxId));
            this.SandboxExecutionId = sandboxExecutionId ?? throw new global::System.ArgumentNullException(nameof(sandboxExecutionId));
            this.SandboxTemplateId = sandboxTemplateId ?? throw new global::System.ArgumentNullException(nameof(sandboxTemplateId));
            this.SandboxBuildId = sandboxBuildId ?? throw new global::System.ArgumentNullException(nameof(sandboxBuildId));
            this.SandboxTeamId = sandboxTeamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEvent" /> class.
        /// </summary>
        public SandboxEvent()
        {
        }

    }
}