
#nullable enable

namespace E2B
{
    /// <summary>
    /// The project's stored settings. PUT replaces the complete document.
    /// </summary>
    public sealed partial class ProjectSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.SandboxSettings SandboxSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        /// <param name="sandboxSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettings(
            global::E2B.SandboxSettings sandboxSettings)
        {
            this.SandboxSettings = sandboxSettings ?? throw new global::System.ArgumentNullException(nameof(sandboxSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        public ProjectSettings()
        {
        }

    }
}