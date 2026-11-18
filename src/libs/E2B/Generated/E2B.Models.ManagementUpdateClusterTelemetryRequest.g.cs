
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementUpdateClusterTelemetryRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telemetry_client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TelemetryClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUpdateClusterTelemetryRequest" /> class.
        /// </summary>
        /// <param name="telemetryClientId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementUpdateClusterTelemetryRequest(
            string telemetryClientId)
        {
            this.TelemetryClientId = telemetryClientId ?? throw new global::System.ArgumentNullException(nameof(telemetryClientId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUpdateClusterTelemetryRequest" /> class.
        /// </summary>
        public ManagementUpdateClusterTelemetryRequest()
        {
        }

    }
}