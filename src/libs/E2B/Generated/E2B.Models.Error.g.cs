
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// Error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// Machine-readable semantic error code. Not a closed set; initial values: sandbox_capacity_unavailable, sandbox_placement_timeout, sandbox_no_compatible_node, sandbox_create_failed, internal_server_error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code
        /// </param>
        /// <param name="message">
        /// Error
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable semantic error code. Not a closed set; initial values: sandbox_capacity_unavailable, sandbox_placement_timeout, sandbox_no_compatible_node, sandbox_create_failed, internal_server_error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            int code,
            string message,
            string? errorCode)
        {
            this.Code = code;
            this.ErrorCode = errorCode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }

    }
}