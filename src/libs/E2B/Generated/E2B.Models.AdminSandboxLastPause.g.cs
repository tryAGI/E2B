
#nullable enable

namespace E2B
{
    /// <summary>
    /// The snapshot as the most recent pause left it. A resume can change<br/>
    /// whether the sandbox auto-pauses without rewriting it, and restoring an<br/>
    /// older build does not change it.
    /// </summary>
    public sealed partial class AdminSandboxLastPause
    {
        /// <summary>
        /// Kind of snapshot the most recent pause took
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.AdminSandboxPauseKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminSandboxPauseKind Kind { get; set; }

        /// <summary>
        /// Whether the sandbox pauses instead of being killed on timeout, as of the most recent pause
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoPause")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoPause { get; set; }

        /// <summary>
        /// Kind of snapshot an auto-pause takes, as of the most recent pause
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoPauseKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.AdminSandboxPauseKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminSandboxPauseKind AutoPauseKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxLastPause" /> class.
        /// </summary>
        /// <param name="kind">
        /// Kind of snapshot the most recent pause took
        /// </param>
        /// <param name="autoPause">
        /// Whether the sandbox pauses instead of being killed on timeout, as of the most recent pause
        /// </param>
        /// <param name="autoPauseKind">
        /// Kind of snapshot an auto-pause takes, as of the most recent pause
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxLastPause(
            global::E2B.AdminSandboxPauseKind kind,
            bool autoPause,
            global::E2B.AdminSandboxPauseKind autoPauseKind)
        {
            this.Kind = kind;
            this.AutoPause = autoPause;
            this.AutoPauseKind = autoPauseKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxLastPause" /> class.
        /// </summary>
        public AdminSandboxLastPause()
        {
        }

    }
}