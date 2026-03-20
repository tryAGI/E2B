
#nullable enable

namespace E2B
{
    /// <summary>
    /// Direction of the logs that should be returned
    /// </summary>
    public enum LogsDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Forward,
        /// <summary>
        /// 
        /// </summary>
        Backward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogsDirection value)
        {
            return value switch
            {
                LogsDirection.Forward => "forward",
                LogsDirection.Backward => "backward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogsDirection? ToEnum(string value)
        {
            return value switch
            {
                "forward" => LogsDirection.Forward,
                "backward" => LogsDirection.Backward,
                _ => null,
            };
        }
    }
}