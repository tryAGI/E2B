
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxIamToken
    {
        /// <summary>
        /// Audience of the workload token, stored exactly as provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// Workload token type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxIamToken" /> class.
        /// </summary>
        /// <param name="audience">
        /// Audience of the workload token, stored exactly as provided.
        /// </param>
        /// <param name="tokenType">
        /// Workload token type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxIamToken(
            string audience,
            string tokenType)
        {
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.TokenType = tokenType ?? throw new global::System.ArgumentNullException(nameof(tokenType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxIamToken" /> class.
        /// </summary>
        public SandboxIamToken()
        {
        }

    }
}