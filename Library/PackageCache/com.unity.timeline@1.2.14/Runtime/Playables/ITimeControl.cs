                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
 namespace UnityEngine.Timeline
{
    /// <summary>
    /// Interface that can be implemented by MonoBehaviours indicating that they receive time-related control calls from a PlayableGraph.
    /// </summary>
    /// <remarks>
    /// Implementing this interface on MonoBehaviours attached to GameObjects under control by control-tracks will cause them to be notified when associated Timeline clips are active.
    /// </remarks>
    public interface ITimeControl
    {
        /// <summary>
    