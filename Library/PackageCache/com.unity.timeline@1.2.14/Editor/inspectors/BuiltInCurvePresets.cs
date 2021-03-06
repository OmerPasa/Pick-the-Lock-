                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEngine;

namespace UnityEditor.Timeline
{
    // Preset libraries
    static class BuiltInPresets
    {
        static CurvePresetLibrary s_BlendInPresets;
        static CurvePresetLibrary s_BlendOutPresets;

        internal static CurvePresetLibrary blendInPresets
        {
            get
            {
                if (s_BlendInPresets == null)
                {
                    s_BlendInPresets = ScriptableObject.CreateInstance<CurvePresetLibrary>();
                    s_BlendInPresets.Add(new AnimationCurve(CurveEditorWindow.GetConstantKeys(1f)), "None");
                    s_BlendInPresets.Add(new AnimationCurve(CurveEditorWindow.GetLinearKeys()), "Linear");
                    s_BlendInPresets.Add(new AnimationCurve(CurveEditorWindow.GetEaseInKeys()), "EaseIn");
                    s_BlendInPresets.Add(new AnimationCurve(CurveEditorWindow.GetEaseOutKeys()), "EaseOut");
                    s_BlendInPresets.Add(new AnimationCurve(CurveEditorWindow.GetEaseInOutKeys()), "EaseInOut");
                }
                return s_BlendInPresets;
            }
        }

        internal static CurvePresetLibrary blendOutPresets
        {
            get
            {
                if (s_BlendOutPresets == null)
                {
                    s_BlendOutPresets = ScriptableObject.CreateInstance<CurvePresetLibrary>();
                    s_BlendOutPresets.Add(new AnimationCurve(CurveEditorWindow.GetConstantKeys(1f)), "None");
                    s_BlendOutPresets.Add(ReverseCurve(new AnimationCurve(CurveEditorWindow.GetLinearKeys())), "Linear");
                    s_BlendOutPresets.Add(ReverseCurve(new AnimationCurve(CurveEditorWindow.GetEaseInKeys())), "EaseIn");
                    s_BlendOutPresets.Add(ReverseCurve(new AnimationCurve(CurveEditorWindow.GetEaseOutKeys())), "EaseOut");
                    s_BlendOutPresets.Add(ReverseCurve(new AnimationCurve(CurveEditorWindow.GetEaseInOutK