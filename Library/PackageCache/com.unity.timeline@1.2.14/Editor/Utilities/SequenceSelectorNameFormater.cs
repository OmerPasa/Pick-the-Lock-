EditorGUI.DrawRect(rect, c);
            if (state.IsEditingAPrefabAsset())
            {
                c = SceneView.kSceneViewPrefabBackground.Color;
                c.a = 0.5f;
                EditorGUI.DrawRect(rect, c);
            }
        }
    }
}
                                                                                                                                                                                                                                                             using System;
using System.Collections.Generic;

namespace UnityEditor.Timeline
{
    // Class used for uniquely format names used in the GenericMenu. We can't add duplicate MenuItem in GenericMenu
    // so that's why we need to keep information about the text we want to uniquely format.
    class SequenceMenuNameFormater
    {
        Dictionary<int, int> m_UniqueItem = n