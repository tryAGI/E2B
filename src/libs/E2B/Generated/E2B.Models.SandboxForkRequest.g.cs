
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxForkRequest
    {
        /// <summary>
        /// Time to live for the new forked sandboxes in seconds.<br/>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Number of forked sandboxes to create. All forks boot from the same snapshot, so the snapshot is captured once regardless of count. Each fork succeeds or fails independently; the outcome of each is reported in its entry of the response list.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxForkRequest" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Time to live for the new forked sandboxes in seconds.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="count">
        /// Number of forked sandboxes to create. All forks boot from the same snapshot, so the snapshot is captured once regardless of count. Each fork succeeds or fails independently; the outcome of each is reported in its entry of the response list.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxForkRequest(
            int? timeout,
            int? count)
        {
            this.Timeout = timeout;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxForkRequest" /> class.
        /// </summary>
        public SandboxForkRequest()
        {
        }

    }
}