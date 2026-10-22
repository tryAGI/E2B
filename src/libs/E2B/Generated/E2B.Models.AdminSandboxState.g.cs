
#nullable enable

namespace E2B
{
    /// <summary>
    /// State after the sandbox's latest create, resume, pause or kill event
    /// </summary>
    public enum AdminSandboxState
    {
        /// <summary>
        ///
        /// </summary>
        AdminSandboxStateKilled,
        /// <summary>
        ///
        /// </summary>
        AdminSandboxStatePaused,
        /// <summary>
        ///
        /// </summary>
        AdminSandboxStateRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminSandboxStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminSandboxState value)
        {
            return value switch
            {
                AdminSandboxState.AdminSandboxStateKilled => "killed",
                AdminSandboxState.AdminSandboxStatePaused => "paused",
                AdminSandboxState.AdminSandboxStateRunning => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminSandboxState? ToEnum(string value)
        {
            return value switch
            {
                "killed" => AdminSandboxState.AdminSandboxStateKilled,
                "paused" => AdminSandboxState.AdminSandboxStatePaused,
                "running" => AdminSandboxState.AdminSandboxStateRunning,
                _ => null,
            };
        }
    }
}