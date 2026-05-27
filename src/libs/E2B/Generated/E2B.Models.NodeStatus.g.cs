
#nullable enable

namespace E2B
{
    /// <summary>
    /// Status of the node.<br/>
    /// - draining: the node is bound to be shut down. It will not accept new sandboxes and will stop once all existing sandboxes are done.<br/>
    /// - standby: the node is not actively used, but it can return to ready and continue serving traffic.
    /// </summary>
    public enum NodeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        NodeStatusConnecting,
        /// <summary>
        /// the node is bound to be shut down. It will not accept new sandboxes and will stop once all existing sandboxes are done.
        /// </summary>
        NodeStatusDraining,
        /// <summary>
        /// the node is not actively used, but it can return to ready and continue serving traffic.
        /// </summary>
        NodeStatusReady,
        /// <summary>
        /// the node is not actively used, but it can return to ready and continue serving traffic.
        /// </summary>
        NodeStatusStandby,
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
                NodeStatus.NodeStatusConnecting => "connecting",
                NodeStatus.NodeStatusDraining => "draining",
                NodeStatus.NodeStatusReady => "ready",
                NodeStatus.NodeStatusStandby => "standby",
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
                "connecting" => NodeStatus.NodeStatusConnecting,
                "draining" => NodeStatus.NodeStatusDraining,
                "ready" => NodeStatus.NodeStatusReady,
                "standby" => NodeStatus.NodeStatusStandby,
                "unhealthy" => NodeStatus.NodeStatusUnhealthy,
                _ => null,
            };
        }
    }
}