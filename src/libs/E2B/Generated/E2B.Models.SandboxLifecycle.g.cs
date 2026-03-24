
#nullable enable

namespace E2B
{
    /// <summary>
    /// Sandbox lifecycle policy returned by sandbox info.
    /// </summary>
    public sealed partial class SandboxLifecycle
    {
        /// <summary>
        /// Whether the sandbox can auto-resume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoResume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoResume { get; set; }

        /// <summary>
        /// Action taken when the sandbox times out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onTimeout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.SandboxOnTimeoutJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.SandboxOnTimeout OnTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLifecycle" /> class.
        /// </summary>
        /// <param name="autoResume">
        /// Whether the sandbox can auto-resume.
        /// </param>
        /// <param name="onTimeout">
        /// Action taken when the sandbox times out.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLifecycle(
            bool autoResume,
            global::E2B.SandboxOnTimeout onTimeout)
        {
            this.AutoResume = autoResume;
            this.OnTimeout = onTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLifecycle" /> class.
        /// </summary>
        public SandboxLifecycle()
        {
        }
    }
}