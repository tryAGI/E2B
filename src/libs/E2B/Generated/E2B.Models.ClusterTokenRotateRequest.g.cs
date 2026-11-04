
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClusterTokenRotateRequest
    {
        /// <summary>
        /// New cluster access token. Write-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTokenRotateRequest" /> class.
        /// </summary>
        /// <param name="token">
        /// New cluster access token. Write-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterTokenRotateRequest(
            string token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterTokenRotateRequest" /> class.
        /// </summary>
        public ClusterTokenRotateRequest()
        {
        }

    }
}