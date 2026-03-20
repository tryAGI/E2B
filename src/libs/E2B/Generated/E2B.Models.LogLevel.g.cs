
#nullable enable

namespace E2B
{
    /// <summary>
    /// State of the sandbox
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warn,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogLevel value)
        {
            return value switch
            {
                LogLevel.Debug => "debug",
                LogLevel.Info => "info",
                LogLevel.Warn => "warn",
                LogLevel.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogLevel? ToEnum(string value)
        {
            return value switch
            {
                "debug" => LogLevel.Debug,
                "info" => LogLevel.Info,
                "warn" => LogLevel.Warn,
                "error" => LogLevel.Error,
                _ => null,
            };
        }
    }
}