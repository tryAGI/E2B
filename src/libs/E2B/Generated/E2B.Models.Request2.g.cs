
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request2
    {
        /// <summary>
        /// Duration for which the sandbox should be kept alive in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration for which the sandbox should be kept alive in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request2(
            int? duration)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        public Request2()
        {
        }
    }
}