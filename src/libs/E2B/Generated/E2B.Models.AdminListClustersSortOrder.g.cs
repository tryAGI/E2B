
#nullable enable

namespace E2B
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum AdminListClustersSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        AdminListClustersSortOrderAsc,
        /// <summary>
        ///
        /// </summary>
        AdminListClustersSortOrderDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListClustersSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListClustersSortOrder value)
        {
            return value switch
            {
                AdminListClustersSortOrder.AdminListClustersSortOrderAsc => "asc",
                AdminListClustersSortOrder.AdminListClustersSortOrderDesc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListClustersSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AdminListClustersSortOrder.AdminListClustersSortOrderAsc,
                "desc" => AdminListClustersSortOrder.AdminListClustersSortOrderDesc,
                _ => null,
            };
        }
    }
}