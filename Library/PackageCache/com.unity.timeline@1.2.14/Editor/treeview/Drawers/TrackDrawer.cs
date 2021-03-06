                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
namespace UnityEditor.Timeline
{
    class TrackDrawer : GUIDrawer
    {
        internal WindowState sequencerState { get; set; }


        public static TrackDrawer CreateInstance(TrackAsset trackAsset)
        {
            if (trackAsset == null)
                return Activator.CreateInstance<TrackDrawer>();

            TrackDrawer drawer;

            try
            {
                drawer = (TrackDrawer)Activator.CreateInstance(TimelineHelpers.GetCustomDrawer(trackAsset.GetType()));
            }
            catch (Exception)
            {
                drawer = Activator.CreateInstance<TrackDrawer>();
            }

            drawer.track = trackAsset;
            return drawer;
        }

        protected TrackAsset track { get; private set; }

        public virtual bool DrawTrackHeaderButton(Rect rect, Trac