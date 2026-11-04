
#nullable enable

namespace E2B
{
    /// <summary>
    /// Default Value: endpoint
    /// </summary>
    public enum AdminListClustersSortBy
    {
        /// <summary>
        ///
        /// </summary>
        Endpoint,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        TeamCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListClustersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListClustersSortBy value)
        {
            return value switch
            {
                AdminListClustersSortBy.Endpoint => "endpoint",
                AdminListClustersSortBy.Name => "name",
                AdminListClustersSortBy.TeamCount => "teamCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListClustersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "endpoint" => AdminListClustersSortBy.Endpoint,
                "name" => AdminListClustersSortBy.Name,
                "teamCount" => AdminListClustersSortBy.TeamCount,
                _ => null,
            };
        }
    }
}