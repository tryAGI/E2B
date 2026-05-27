
#nullable enable

namespace E2B
{
    /// <summary>
    /// Transformations applied to matching egress requests before forwarding.
    /// </summary>
    public sealed partial class SandboxNetworkTransform
    {
        /// <summary>
        /// HTTP headers to inject or override in matching requests. An existing header with the same name is replaced. Values are plain strings; secret resolution happens client-side before sending to the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkTransform" /> class.
        /// </summary>
        /// <param name="headers">
        /// HTTP headers to inject or override in matching requests. An existing header with the same name is replaced. Values are plain strings; secret resolution happens client-side before sending to the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxNetworkTransform(
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkTransform" /> class.
        /// </summary>
        public SandboxNetworkTransform()
        {
        }

    }
}