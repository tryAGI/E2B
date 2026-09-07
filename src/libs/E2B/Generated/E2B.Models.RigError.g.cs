
#nullable enable

namespace E2B
{
    /// <summary>
    /// Scaling error on the rig's scaling group, e.g. a failed instance creation due to resource exhaustion
    /// </summary>
    public sealed partial class RigError
    {
        /// <summary>
        /// When the error occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Provider-specific error code (e.g. ZONE_RESOURCE_POOL_EXHAUSTED, Failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Instance the error relates to, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance")]
        public string? Instance { get; set; }

        /// <summary>
        /// Action being performed when the error occurred (e.g. CREATING)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RigError" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// When the error occurred
        /// </param>
        /// <param name="code">
        /// Provider-specific error code (e.g. ZONE_RESOURCE_POOL_EXHAUSTED, Failed)
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="instance">
        /// Instance the error relates to, if any
        /// </param>
        /// <param name="action">
        /// Action being performed when the error occurred (e.g. CREATING)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RigError(
            global::System.DateTime timestamp,
            string code,
            string message,
            string? instance,
            string? action)
        {
            this.Timestamp = timestamp;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Instance = instance;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RigError" /> class.
        /// </summary>
        public RigError()
        {
        }

    }
}