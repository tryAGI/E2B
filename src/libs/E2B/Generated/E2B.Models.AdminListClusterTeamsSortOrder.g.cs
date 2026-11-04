
#nullable enable

namespace E2B
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum AdminListClusterTeamsSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        AdminListClusterTeamsSortOrderAsc,
        /// <summary>
        ///
        /// </summary>
        AdminListClusterTeamsSortOrderDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListClusterTeamsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListClusterTeamsSortOrder value)
        {
            return value switch
            {
                AdminListClusterTeamsSortOrder.AdminListClusterTeamsSortOrderAsc => "asc",
                AdminListClusterTeamsSortOrder.AdminListClusterTeamsSortOrderDesc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListClusterTeamsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AdminListClusterTeamsSortOrder.AdminListClusterTeamsSortOrderAsc,
                "desc" => AdminListClusterTeamsSortOrder.AdminListClusterTeamsSortOrderDesc,
                _ => null,
            };
        }
    }
}