
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public enum Metric
    {
        /// <summary>
        /// 
        /// </summary>
        ConcurrentSandboxes,
        /// <summary>
        /// 
        /// </summary>
        SandboxStartRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Metric value)
        {
            return value switch
            {
                Metric.ConcurrentSandboxes => "concurrent_sandboxes",
                Metric.SandboxStartRate => "sandbox_start_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Metric? ToEnum(string value)
        {
            return value switch
            {
                "concurrent_sandboxes" => Metric.ConcurrentSandboxes,
                "sandbox_start_rate" => Metric.SandboxStartRate,
                _ => null,
            };
        }
    }
}