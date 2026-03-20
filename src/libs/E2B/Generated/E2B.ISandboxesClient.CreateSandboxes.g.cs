#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox from the template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesAsync(

            global::E2B.NewSandbox request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox from the template
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the required template
        /// </param>
        /// <param name="timeout">
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="autoPause">
        /// Automatically pauses the sandbox after the timeout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoResume">
        /// Auto-resume configuration for paused sandboxes.
        /// </param>
        /// <param name="secure">
        /// Secure all system communication with sandbox
        /// </param>
        /// <param name="allowInternetAccess">
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </param>
        /// <param name="network"></param>
        /// <param name="metadata"></param>
        /// <param name="envVars"></param>
        /// <param name="mcp">
        /// MCP configuration for the sandbox
        /// </param>
        /// <param name="volumeMounts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesAsync(
            string templateID,
            int? timeout = default,
            bool? autoPause = default,
            global::E2B.SandboxAutoResumeConfig? autoResume = default,
            bool? secure = default,
            bool? allowInternetAccess = default,
            global::E2B.SandboxNetworkConfig? network = default,
            object? metadata = default,
            object? envVars = default,
            object? mcp = default,
            global::System.Collections.Generic.IList<global::E2B.SandboxVolumeMount>? volumeMounts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}