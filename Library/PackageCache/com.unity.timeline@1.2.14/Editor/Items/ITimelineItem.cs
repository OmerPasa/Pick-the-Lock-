USBC����     
* )   �       �                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              	 using System;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    interface ITimelineItem : IEquatable<ITimelineItem>
    {
        double start { get; set; }
        double end { get; }
        double duration { get; }

        TrackAsset parentTrack { get; set; }
        bool IsCompatibleWithTrack(TrackAsset track);

        void Delete();
        ITimelineItem CloneTo(TrackAsset parent, double time);
        void PushUndo(string operation);

 