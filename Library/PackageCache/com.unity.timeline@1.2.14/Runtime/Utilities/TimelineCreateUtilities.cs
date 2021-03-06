.frameRate;
            }
            return length;
        }

        static string RemoveChar(string str, Func<char, bool> charToRemoveFunc)
        {
            var len = str.Length;
            var src = str.ToCharArray();
            var dstIdx = 0;
            for (var i = 0; i < len; i++)
            {
                if (!charToRemoveFunc(src[i]))
                    src[dstIdx++] = src[i];
            }
            return new string(src, 0, dstIdx);
        }
    }
}
                             using System;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UnityEngine.Timeline
{
    static class TimelineCreateUtilities
    {
        // based off of ObjectNames.GetUniqueName, but can exist in runtime
        public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name)
        {
            if (!tracks.Exists(x => ((object)x) != null && x.name == name))
                return name;

            int numberInParentheses = 0;
            string baseName = name;

            if (!string.IsNullOrEmpty(name) && name[name.Length - 1] == ')')
            {
                int index = name.LastIndexOf('(');
                if (index > 0)
                {
                    string numberString = name.Substring(index + 1, name.Length - index - 2);
                    if (int.TryParse(numberString, out numberInParentheses))
                    {
                        numberInParentheses++;
                        baseName = name.Substring(0, index);
                    }
                }
            }

            baseName = baseName.TrimEnd();

            for (int i = numberInParentheses; i < numberInParentheses + 5000; i++)
            {
                if (i > 0)
                {
                    string result = string.Format("{0} ({1})", baseName, i);
                    if (!tracks.Exists(x => ((object)x) != null && x.name == result))
                        return result;
                }
            }

            // Fallback
            return name;
        }

        public static void SaveAssetIntoObject(Object childAsset, Object masterAsset)
        {
            if (childAsset == null || masterAsset == null)
                return;

            if ((masterAsset.hideFlags & HideFlags.DontSave) != 0)
            {
                childAsset.hideFlags |= HideFlags.DontSave;
            }
            else
            {
                childAsset.hideFlags |= HideFlags.HideInHierarchy;
#if UNITY_EDITOR
                if (!AssetDatabase.Contains(childAsset) && AssetDatabase.Contains(masterAsset))
                    AssetDatabase.AddObjectToAsset(childAsset, masterAsset);
#endif
            }
        }

        public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy)
        {
            var timelineAsset = track != null ? track.timelineAsset : null;
            var trackFlags = track != null ? track.hideFlags : HideFlags.None;

            var curves = new AnimationClip
            {
                legacy = isLegacy,

                name = name,

                frameRate = timelineAsset == null
                    ? TimelineAsset.EditorSettings.kDefaultFps
                    : timelineAsset.editorSettings.fps
            };

            SaveAssetIntoObject(curves, timelineAsset);
            curves.hideFlags = trackFlags & ~HideFlags.HideInHierarchy; // Never hide in hierarchy

            TimelineUndo.RegisterCreatedObjectUndo(curves, "Create Curves");

            return curves;
        }

        public static bool ValidateParentTrack(TrackAsset parent, Type childType)
        {
            if (childType == null || !typeof(TrackAsset).IsAssignableFrom(childType))
                return false;

            // no parent is valid for any type
            if (parent == null)
                return true;

            // A track supports layers if it implements ILayerable. Only supported for parents that are
            // the same exact type as the child class, and 1 level of nesting only
  USBC0���     
* zԀ  �       'ValidateParentTrack(TrackAsset parent, Type childType)
        {
            if (childType == null || !typeof(TrackAsset).IsAssignableFrom(childType))
                return false;

            // no parent is valid for any type
            if (parent == null)
                return true;

            // A track supports layers if it implements I