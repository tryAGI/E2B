
#nullable enable

namespace E2B
{
    /// <summary>
    /// What the sandbox's latest pause saved. `full` saved the filesystem and the memory, and resuming restores the sandbox where it left off. `filesystem` saved only the filesystem, and resuming reboots the sandbox from disk. Returned for a paused sandbox once its pause has finished, and omitted while it is still pausing.
    /// </summary>
    public enum SandboxPauseMode
    {
        /// <summary>
        ///
        /// </summary>
        Filesystem,
        /// <summary>
        ///
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxPauseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxPauseMode value)
        {
            return value switch
            {
                SandboxPauseMode.Filesystem => "filesystem",
                SandboxPauseMode.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxPauseMode? ToEnum(string value)
        {
            return value switch
            {
                "filesystem" => SandboxPauseMode.Filesystem,
                "full" => SandboxPauseMode.Full,
                _ => null,
            };
        }
    }
}