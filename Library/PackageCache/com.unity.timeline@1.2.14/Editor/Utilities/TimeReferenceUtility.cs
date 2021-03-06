o r U t i l i t y . c s *�     � �     ?�     V�e�w� ,���D�1�w��2�e�w��       �                 T i m e l i n e I n s p e c t o r U t i l i t y . c s . m e t a       .�    
 � n     ?�     vg`f�w� ,���D�Ec���w�]ī���        �               T r a c k A s s e t I n s p e c t o r . c s . +�     � x     ?�     ���e�w� ,���D�E���w�@�e�w��       �                T r a c k A s s e t I n s p e c t o r . c s . m e t a                                                                     " using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    static class TimeReferenceUtility
    {
        static WindowState state { get { return TimelineWindow.instance.state; } }

        public static double SnapToFrame(double time)
        {
            if (state.timeReferenceMode == TimeReferenceMode.Global)
            {
                time = state.editSequence.ToGlobalTime(time);
                time = TimeUtility.RoundToFrame(time, state.referenceSequence.frameRate);
                return state.editSequence.ToLocalTime(time);
            }

            return TimeUtility.RoundToFrame(time, state.referenceSequence.frameRate);
        }

        public static string ToTimeString(double time, string format = "F2")
        {
            if (state.timeReferenceMode == TimeReferenceMode.Global)
                time = state.editSequence.ToGlobalTime(time);

            return state.editSequence.viewModel.timeInFrames ?
                TimeUtility.TimeAsFrames(time, state.referenceSequence.frameRate, format) :
                TimeUtility.TimeAsTimeCode(time, state.referenceSequence.frameRate, format);
        }

        public static double FromTimeString(string timeString)
        {
            double newTime;

            if (state.timeInFrames)
            {
                double newFrameDouble;
                if (double.TryParse(timeString, out newFrameDouble))
                    newTime = TimeUtility.FromFrames(newFrameDouble, state.referenceSequence.frameRate);