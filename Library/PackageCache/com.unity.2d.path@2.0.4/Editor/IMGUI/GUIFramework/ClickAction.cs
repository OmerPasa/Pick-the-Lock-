                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ﻿using System;
using UnityEngine;

namespace UnityEditor.U2D.Path.GUIFramework
{
    public class ClickAction : HoveredControlAction
    {
        private int m_Button;
        private bool m_UseEvent;
        public int clickCount = 1;
        public Action<IGUIState, Control> onClick;
        private int m_ClickCounter = 0;

        public ClickAction(Control control, int button, bool useEvent = true) : base(control)
        {
            m_Button = button;
            m_UseEvent = useEvent;
        }

        protected override bool GetTriggerContidtion(IGUIState guiState)
        {
            if (guiState.mouseButton == m_Button && guiState.eventType == EventType.MouseDown)
            {
                if (guiState.clickCount == 1)
                    m_ClickCounter = 0;

                ++m_ClickCounter;

                if (m_ClickCounter == clickCount)
     