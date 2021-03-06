                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEngine;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    /// <summary>
    /// Implement this interface on a TrackAsset derived class to support layers
    /// </summary>
    public interface ILayerable
    {
        /// <summary>
        /// Creates a mixer that blends track mixers.
        /// </summary>
        /// <param name="graph">The graph where the mixer playable will be added.</param>
        /// <param name="go">The GameObject