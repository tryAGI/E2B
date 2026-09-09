
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateBuildRequestV3
    {
        /// <summary>
        /// Name of the template. Can include a tag with colon separator (e.g. "my-template" or "my-template:v1"). If tag is included, it will be treated as if the tag was provided in the tags array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tags to assign to the template build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Alias of the template. Deprecated, use name instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TeamID { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// Requested minimum free space after the template's build steps, in MiB. Omit to use the team's default. Set to 0 to request no minimum free-disk growth. The filesystem is never shrunk, including inherited or already-larger filesystems. Growth is best effort, so filesystem metadata can leave the available space slightly below the requested minimum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minFreeDiskMb")]
        public int? MinFreeDiskMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequestV3" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the template. Can include a tag with colon separator (e.g. "my-template" or "my-template:v1"). If tag is included, it will be treated as if the tag was provided in the tags array.
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template build
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="minFreeDiskMb">
        /// Requested minimum free space after the template's build steps, in MiB. Omit to use the team's default. Set to 0 to request no minimum free-disk growth. The filesystem is never shrunk, including inherited or already-larger filesystems. Growth is best effort, so filesystem metadata can leave the available space slightly below the requested minimum.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateBuildRequestV3(
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            int? cpuCount,
            int? memoryMB,
            int? minFreeDiskMb)
        {
            this.Name = name;
            this.Tags = tags;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
            this.MinFreeDiskMb = minFreeDiskMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequestV3" /> class.
        /// </summary>
        public TemplateBuildRequestV3()
        {
        }

    }
}