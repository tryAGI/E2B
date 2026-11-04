
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminSandboxBuildRestoreRequest
    {
        /// <summary>
        /// Build to make current. It must be ready and already assigned to the<br/>
        /// sandbox's snapshot template under the default tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuildRestoreRequest" /> class.
        /// </summary>
        /// <param name="buildID">
        /// Build to make current. It must be ready and already assigned to the<br/>
        /// sandbox's snapshot template under the default tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxBuildRestoreRequest(
            global::System.Guid buildID)
        {
            this.BuildID = buildID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuildRestoreRequest" /> class.
        /// </summary>
        public AdminSandboxBuildRestoreRequest()
        {
        }

    }
}