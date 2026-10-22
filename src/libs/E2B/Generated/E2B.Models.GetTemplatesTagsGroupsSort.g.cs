
#nullable enable

namespace E2B
{
    /// <summary>
    /// Default Value: latest_desc
    /// </summary>
    public enum GetTemplatesTagsGroupsSort
    {
        /// <summary>
        ///
        /// </summary>
        LatestAsc,
        /// <summary>
        ///
        /// </summary>
        LatestDesc,
        /// <summary>
        ///
        /// </summary>
        NameAsc,
        /// <summary>
        ///
        /// </summary>
        NameDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTemplatesTagsGroupsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTemplatesTagsGroupsSort value)
        {
            return value switch
            {
                GetTemplatesTagsGroupsSort.LatestAsc => "latest_asc",
                GetTemplatesTagsGroupsSort.LatestDesc => "latest_desc",
                GetTemplatesTagsGroupsSort.NameAsc => "name_asc",
                GetTemplatesTagsGroupsSort.NameDesc => "name_desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTemplatesTagsGroupsSort? ToEnum(string value)
        {
            return value switch
            {
                "latest_asc" => GetTemplatesTagsGroupsSort.LatestAsc,
                "latest_desc" => GetTemplatesTagsGroupsSort.LatestDesc,
                "name_asc" => GetTemplatesTagsGroupsSort.NameAsc,
                "name_desc" => GetTemplatesTagsGroupsSort.NameDesc,
                _ => null,
            };
        }
    }
}