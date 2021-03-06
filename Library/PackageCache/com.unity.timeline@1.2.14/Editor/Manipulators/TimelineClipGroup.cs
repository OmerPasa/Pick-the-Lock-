                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    class TimelineClipGroup
    {
        readonly TimelineClip[] m_Clips;
        readonly TimelineClip m_LeftMostClip;
        readonly TimelineClip m_RightMostClip;

        public TimelineClip[] clips
        {
            get { return m_Clips; }
        }

        public double start
        {
            get { return m_LeftMostClip.start; }
            set
            {
                var offset = value - m_LeftMostClip.start;

                foreach (var clip in m_Clips)
                    clip.start += offset;
            }
        }

        public double end
        {
            get { return m_RightMostClip.end; }
        }

        public TimelineClipGroup(IEnumerable<TimelineClip> clips)
  