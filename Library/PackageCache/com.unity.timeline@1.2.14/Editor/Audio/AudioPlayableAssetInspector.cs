                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
 using UnityEditor;
using UnityEditor.Timeline;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [CustomEditor(typeof(AudioPlayableAsset))]
    class AudioPlayableAssetInspector : BasicAssetInspector
    {
        public override void ApplyChanges()
        {
            // At this point, we are guaranteed that the Timeline