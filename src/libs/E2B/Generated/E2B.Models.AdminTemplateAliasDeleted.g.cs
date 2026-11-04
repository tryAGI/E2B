
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAliasDeleted
    {
        /// <summary>
        /// Identifier of the removed alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AliasID { get; set; }

        /// <summary>
        /// Identifier of the template the alias resolved to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// The removed alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasDeleted" /> class.
        /// </summary>
        /// <param name="aliasID">
        /// Identifier of the removed alias
        /// </param>
        /// <param name="templateID">
        /// Identifier of the template the alias resolved to
        /// </param>
        /// <param name="alias">
        /// The removed alias
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAliasDeleted(
            global::System.Guid aliasID,
            string templateID,
            string alias)
        {
            this.AliasID = aliasID;
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasDeleted" /> class.
        /// </summary>
        public AdminTemplateAliasDeleted()
        {
        }

    }
}