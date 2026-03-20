
#nullable enable

namespace E2B
{
    /// <summary>
    /// Source of the logs that should be returned
    /// </summary>
    public enum LogsSource
    {
        /// <summary>
        /// 
        /// </summary>
        Temporary,
        /// <summary>
        /// 
        /// </summary>
        Persistent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogsSource value)
        {
            return value switch
            {
                LogsSource.Temporary => "temporary",
                LogsSource.Persistent => "persistent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogsSource? ToEnum(string value)
        {
            return value switch
            {
                "temporary" => LogsSource.Temporary,
                "persistent" => LogsSource.Persistent,
                _ => null,
            };
        }
    }
}