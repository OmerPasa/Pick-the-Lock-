                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityEditor.Timeline
{
    struct TrackItemsDrawer
    {
        List<ItemsLayer> m_Layers;
        ClipsLayer m_ClipsLayer;

        public IEnumerable<TimelineClipGUI> clips
        {
            get { return m_ClipsLayer.items.Cast<TimelineClipGUI>(); }
        }

        public TrackItemsDrawer(IRowGUI parent)
        {
            m_Layers = null;
            m_ClipsLayer = null;
            Build