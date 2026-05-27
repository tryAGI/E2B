
#nullable enable

namespace E2B
{
    /// <summary>
    /// HTTP headers to inject or override in matching requests. An existing header with the same name is replaced. Values are plain strings; secret resolution happens client-side before sending to the API.
    /// </summary>
    public sealed partial class SandboxNetworkTransformHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}