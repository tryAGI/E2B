
#nullable enable

namespace E2B
{
    /// <summary>
    /// Status of the template build
    /// </summary>
    public enum TemplateBuildStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateBuildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateBuildStatus value)
        {
            return value switch
            {
                TemplateBuildStatus.Building => "building",
                TemplateBuildStatus.Waiting => "waiting",
                TemplateBuildStatus.Ready => "ready",
                TemplateBuildStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateBuildStatus? ToEnum(string value)
        {
            return value switch
            {
                "building" => TemplateBuildStatus.Building,
                "waiting" => TemplateBuildStatus.Waiting,
                "ready" => TemplateBuildStatus.Ready,
                "error" => TemplateBuildStatus.Error,
                _ => null,
            };
        }
    }
}