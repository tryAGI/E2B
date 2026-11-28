
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxPausedRetentionRequest
    {
        /// <summary>
        /// Seconds a paused sandbox may stay unused before it is deleted, from 1 hour to 100 years. The clock restarts every time a run of the sandbox ends, by pause or by kill. Null means the sandbox is never deleted automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedRetentionSeconds")]
        public long? PausedRetentionSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPausedRetentionRequest" /> class.
        /// </summary>
        /// <param name="pausedRetentionSeconds">
        /// Seconds a paused sandbox may stay unused before it is deleted, from 1 hour to 100 years. The clock restarts every time a run of the sandbox ends, by pause or by kill. Null means the sandbox is never deleted automatically.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPausedRetentionRequest(
            long? pausedRetentionSeconds)
        {
            this.PausedRetentionSeconds = pausedRetentionSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPausedRetentionRequest" /> class.
        /// </summary>
        public SandboxPausedRetentionRequest()
        {
        }

    }
}