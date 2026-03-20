
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
        NodeStatusReady,
        /// <summary>
        /// 
        /// </summary>
        NodeStatusDraining,
        /// <summary>
        /// 
        /// </summary>
        NodeStatusConnecting,
        /// <summary>
        /// 
        /// </summary>
        NodeStatusUnhealthy,
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
                NodeStatus.NodeStatusReady => "ready",
                NodeStatus.NodeStatusDraining => "draining",
                NodeStatus.NodeStatusConnecting => "connecting",
                NodeStatus.NodeStatusUnhealthy => "unhealthy",
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
                "ready" => NodeStatus.NodeStatusReady,
                "draining" => NodeStatus.NodeStatusDraining,
                "connecting" => NodeStatus.NodeStatusConnecting,
                "unhealthy" => NodeStatus.NodeStatusUnhealthy,
                _ => null,
            };
        }
    }
}