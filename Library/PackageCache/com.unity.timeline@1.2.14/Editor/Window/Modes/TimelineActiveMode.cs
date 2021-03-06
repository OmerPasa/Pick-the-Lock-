                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                namespace UnityEditor.Timeline
{
    class TimelineActiveMode : TimelineMode
    {
        public TimelineActiveMode()
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
                editAsAssetButton = TimelineModeGUIState.Hidden
            };
            mode = TimelineModes.Active;
        }

        public override bool Shoul