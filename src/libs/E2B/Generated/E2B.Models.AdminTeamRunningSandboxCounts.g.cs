
#nullable enable

namespace E2B
{
    /// <summary>
    /// Cached live sandbox index count keyed by team ID. Counts may briefly<br/>
    /// include sandboxes transitioning out of running; teams without indexed<br/>
    /// sandboxes are omitted.
    /// </summary>
    public sealed partial class AdminTeamRunningSandboxCounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}