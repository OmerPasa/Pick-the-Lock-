

        public static void GetInfiniteClipBoundaries(TrackAsset track, out double start, out double end)
        {
            var info = AnimationClipCurveCache.Instance.GetCurveInfo(((AnimationTrack)track).infiniteClip);
            if (info.keyTimes.Length > 0)
            {
                start = info.keyTimes.Min();
                end = info.keyTimes.Max();
            }
            else
            {
                start = end = 0.0f;
            }
        }
    }
}
                              using System;
using UnityEditor.IMGUI.Controls;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline.Signals
{
    static class SignalListFactory
    {
        public static SignalReceiverTreeView CreateSignalInspectorList(TreeViewState state, SignalReceiverHeader header, SignalReceiver target, SerializedObject so)
        {
            return new SignalReceiverTreeView(state, header, target, so);
        }

        public static  SignalReceiverHeader CreateH