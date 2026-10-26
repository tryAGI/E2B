
#nullable enable

namespace E2B
{
    /// <summary>
    /// Default Value: created_at_desc
    /// </summary>
    public enum GetUnstableTemplatesSearchSort
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAtAsc,
        /// <summary>
        ///
        /// </summary>
        CreatedAtDesc,
        /// <summary>
        ///
        /// </summary>
        UpdatedAtAsc,
        /// <summary>
        ///
        /// </summary>
        UpdatedAtDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUnstableTemplatesSearchSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUnstableTemplatesSearchSort value)
        {
            return value switch
            {
                GetUnstableTemplatesSearchSort.CreatedAtAsc => "created_at_asc",
                GetUnstableTemplatesSearchSort.CreatedAtDesc => "created_at_desc",
                GetUnstableTemplatesSearchSort.UpdatedAtAsc => "updated_at_asc",
                GetUnstableTemplatesSearchSort.UpdatedAtDesc => "updated_at_desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUnstableTemplatesSearchSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at_asc" => GetUnstableTemplatesSearchSort.CreatedAtAsc,
                "created_at_desc" => GetUnstableTemplatesSearchSort.CreatedAtDesc,
                "updated_at_asc" => GetUnstableTemplatesSearchSort.UpdatedAtAsc,
                "updated_at_desc" => GetUnstableTemplatesSearchSort.UpdatedAtDesc,
                _ => null,
            };
        }
    }
}