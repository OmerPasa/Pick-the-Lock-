                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityObject = UnityEngine.Object;

namespace UnityEditor.Timeline
{
    static class EditorClipFactory
    {
        static Dictionary<TimelineClip, EditorClip> s_EditorCache = new Dictionary<TimelineClip, EditorClip>();

        public static EditorClip GetEditorClip(TimelineClip clip)
        {
            if (clip == null)
                throw new ArgumentException("parameter cannot be null");

            if (s_EditorCache.ContainsKey(clip))
            {
                var editorClip = s_EditorCache[clip];
                if (editorClip != null)
                    return editorClip;
            }

            var editor = ScriptableObject.CreateInstance<EditorClip>();
            editor.hideFlags |= HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
            editor.lastHash = -1;
            editor.clip = clip;
            s_EditorCache[clip] = editor;

            return editor;
        }

        public static void RemoveE