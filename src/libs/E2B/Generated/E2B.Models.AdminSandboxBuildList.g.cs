
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminSandboxBuildList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuild> Items { get; set; }

        /// <summary>
        /// Number of assignments matching the tag and status filter, ignoring limit and offset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Total { get; set; }

        /// <summary>
        /// Identifier of the template that holds the sandbox's snapshot, null<br/>
        /// when the sandbox has no snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotTemplateID")]
        public string? SnapshotTemplateID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuildList" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="total">
        /// Number of assignments matching the tag and status filter, ignoring limit and offset
        /// </param>
        /// <param name="snapshotTemplateID">
        /// Identifier of the template that holds the sandbox's snapshot, null<br/>
        /// when the sandbox has no snapshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxBuildList(
            global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuild> items,
            long total,
            string? snapshotTemplateID)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Total = total;
            this.SnapshotTemplateID = snapshotTemplateID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuildList" /> class.
        /// </summary>
        public AdminSandboxBuildList()
        {
        }

    }
}