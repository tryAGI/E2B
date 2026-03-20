#nullable enable

namespace E2B
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Create a new team volume
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Volume> CreateVolumesAsync(

            global::E2B.NewVolume request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new team volume
        /// </summary>
        /// <param name="name">
        /// Name of the volume
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Volume> CreateVolumesAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}