                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    class ItemsPerTrack
    {
        public virtual TrackAsset targetTrack { get; }

        public IEnumerable<ITimelineItem> items
        {
            get { return m_ItemsGroup.items; }
        }

        public IEnumerable<TimelineClip> clips
        {
            get { return m_ItemsGroup.items.OfType<ClipItem>().Select(i => i.clip); }
        }

        public IEnumerable<IMarker> markers
        {
            get { return m_ItemsGroup.items.OfType<MarkerItem>().Select(i => i.marker);