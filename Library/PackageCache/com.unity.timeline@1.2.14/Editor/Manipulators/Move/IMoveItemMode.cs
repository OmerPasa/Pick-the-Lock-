                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Timeline
{
    interface IMoveItemMode
    {
        void OnTrackDetach(IEnumerable<ItemsPerTrack> itemsGroups);
        void HandleTrackSwitch(IEnumerable<ItemsPerTrack> itemsGroups);
        bool AllowTrackSwitch();

        double AdjustStartTime(WindowState state, ItemsPerTrack itemsGroup, double time);

        void OnModeClut