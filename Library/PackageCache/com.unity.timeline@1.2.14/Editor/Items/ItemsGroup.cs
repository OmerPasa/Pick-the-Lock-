Times[i]);
        }

        public static double TimeGapBetweenItems(ITimelineItem leftItem, ITimelineItem rightItem, WindowState state)
        {
            if (leftItem is MarkerItem && rightItem is MarkerItem)
            {
                var markerType = ((MarkerItem)leftItem).marker.GetType();
                var gap = state.PixelDeltaToDeltaTime(StyleManager.UssStyleForType(markerType).fixedWidth);
                return gap;
            }

            return 0.0;
        }
    }
}
               using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityEditor.Timeline
{
    class ItemsGroup
    {
        readonly ITimelineItem[] m_Items;
        readonly ITimelineItem m_LeftMostItem;
        readonly ITimelineItem m_RightMostItem;

        public ITimelineItem[] items
        {
            get { return m_Items; }
        }

        public double start
        {
            get { return m_LeftMostItem.start; }
            set
            {
                var offset = value - m_LeftMostItem.start;

                foreach (var clip in m_Items)
                    clip.start += offset;
            }
        }

        public double end
        {
            get { return m_RightMostItem.end; }
        }

        public ITimelineItem leftMostItem
        {
            get { return m_LeftMostItem;  }
        }

        public ITimelineItem rightMostItem
        {
            get { return m_RightMostItem; }
        }

        public ItemsGroup(IEnumerable<ITimelineItem> items)
  