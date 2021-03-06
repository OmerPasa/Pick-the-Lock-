                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline.Signals
{
    [CustomEditor(typeof(SignalAsset))]
    class SignalAssetInspector : Editor
    {
        [MenuItem("Assets/Create/Signal", false, 451)]
        [UsedImplicitly]
        public static void CreateNewSignal()
        {
            var icon = EditorGUIUtility.IconContent("SignalAsset Icon").image as Texture2D;
            ProjectWindowUtil.StartNameEditingIfProjectWindowExis