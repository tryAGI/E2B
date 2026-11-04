
#nullable enable

namespace E2B
{
    /// <summary>
    /// Build status as the builds list reports it.
    /// </summary>
    public enum BuildStatus
    {
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildStatus value)
        {
            return value switch
            {
                BuildStatus.Building => "building",
                BuildStatus.Failed => "failed",
                BuildStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildStatus? ToEnum(string value)
        {
            return value switch
            {
                "building" => BuildStatus.Building,
                "failed" => BuildStatus.Failed,
                "success" => BuildStatus.Success,
                _ => null,
            };
        }
    }
}