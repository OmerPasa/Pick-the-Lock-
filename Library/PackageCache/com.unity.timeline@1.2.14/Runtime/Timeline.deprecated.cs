                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using UnityEngine;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public partial class TimelineAsset
    {
        [Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
        public enum MediaType
        {
            Animation,
            Audio,
            Texture = 2,
            [Obsolete("Use Texture MediaType instead. (UnityUpgradable) -> UnityEngine.Timeline.TimelineAsset/MediaType.Texture", false)] Video = 2,