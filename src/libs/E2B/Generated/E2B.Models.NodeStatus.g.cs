
#nullable enable

namespace E2B
{
    /// <summary>
    /// Status of the node
    /// </summary>
    public enum NodeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Draining,
        /// <summary>
        /// 
        /// </summary>
        Connecting,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeStatus value)
        {
            return value switch
            {
                NodeStatus.Ready => "ready",
                NodeStatus.Draining => "draining",
                NodeStatus.Connecting => "connecting",
                NodeStatus.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeStatus? ToEnum(string value)
        {
            return value switch
            {
                "ready" => NodeStatus.Ready,
                "draining" => NodeStatus.Draining,
                "connecting" => NodeStatus.Connecting,
                "unhealthy" => NodeStatus.Unhealthy,
                _ => null,
            };
        }
    }
}