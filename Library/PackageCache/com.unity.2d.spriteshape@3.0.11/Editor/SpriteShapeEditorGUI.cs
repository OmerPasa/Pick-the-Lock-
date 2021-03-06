USBC�y:�     
* 6�  �       n                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEditor;
using UnityEngine;
using UnityEditor.Sprites;
using System.Collections;
using System.Collections.Generic;

namespace UnityEditor.U2D
{
    public class SpriteShapeEditorGUI
    {
        private const float kSpacingSubLabel = 2.0f;
        private const float kMiniLabelW = 13;
        private const int kVerticalSpacingMultiField = 0;
        private const float kIndentPerLevel = 15;
        public static int s_FoldoutHash = "Foldout".GetHashCode();

        public static void MultiDelayedIntField(Rect position, GUIContent[] subLabels, int[] values, float labelWidth)
        {
            int eCount = values.Length;
            float w = (position.width - (eCount - 1) * kSpacingSubLabel) / eCount;
            Rect nr = new Rect(position);
            nr.width = w;
 