                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              	 using UnityEngine;

namespace UnityEditor.Timeline
{
    class TimelineDisabledMode : TimelineMode
    {
        public TimelineDisabledMode()
        {
            headerState = new HeaderState
            {
                breadCrumb = TimelineModeGUIState.Enabled,
                options = TimelineModeGUIState.Enabled,
                sequenceSelector = TimelineModeGUIState.Enabled
            };

            trackOptionsState = new TrackOptionsState
            {
                newButton = TimelineModeGUIState.Enabled,
                editAsAssetButton = TimelineModeGUIState.Enabled
            };
            mode = TimelineModes.Disabled;
        }

        public ove