
#nullable enable

namespace E2B
{
    /// <summary>
    /// Default Value: createdAt
    /// </summary>
    public enum AdminListClusterTeamsSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListClusterTeamsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListClusterTeamsSortBy value)
        {
            return value switch
            {
                AdminListClusterTeamsSortBy.CreatedAt => "createdAt",
                AdminListClusterTeamsSortBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListClusterTeamsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => AdminListClusterTeamsSortBy.CreatedAt,
                "name" => AdminListClusterTeamsSortBy.Name,
                _ => null,
            };
        }
    }
}