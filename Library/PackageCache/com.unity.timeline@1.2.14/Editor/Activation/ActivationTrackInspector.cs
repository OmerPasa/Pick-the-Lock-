tate GetDisplayState(WindowState state, TimelineClip[] items)
        {
            if (!items.All(TimelineAnimationUtilities.IsAnimationClip))
                return MenuActionDisplayState.Hidden;

            return MenuActionDisplayState.Visible;
        }
    }
}
                                                                                                                                                                                                                                                    using UnityEngine;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    [CustomEditor(typeof(ActivationTrack))]
    class ActivationTrackInspector : TrackAssetInspector
    {
        static class Styles
        {
            public static readonly GUIContent PostPlaybackStateText = EditorGUIUtility.TrTextContent("Post-playback state");
        }

        SerializedProperty m_PostPlaybackProperty;

        public override void OnInspectorGUI()
        {
            using (new EditorGUI.DisabledScope(IsTrackLocked()))
            {
                serializedObject.Update();

                EditorGUI.BeginChangeCheck();

                if (m_PostPlaybackProperty != null)
                    EditorGUILayout.PropertyField(m_PostPlaybackProperty, Styles.PostPlaybackStateText);

                if (Editor