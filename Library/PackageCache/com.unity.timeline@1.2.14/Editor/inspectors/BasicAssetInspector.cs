                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    // Simple inspector used by built in assets
    //  that only need to hide the script field
    class BasicAssetInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            serializedObject.Update();

            SerializedProperty property = serializedObject.GetIterator();
            bool expanded = true;
            while (property.NextVisible(expanded))
            {
                expanded = false;
                if (SkipField(property.propertyPath))
                    continue;
                EditorGUILayout.PropertyField(