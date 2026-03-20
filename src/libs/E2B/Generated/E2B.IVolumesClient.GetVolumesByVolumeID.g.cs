#nullable enable

namespace E2B
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Get team volume info
        /// </summary>
        /// <param name="volumeID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Volume> GetVolumesByVolumeIDAsync(
            string volumeID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}