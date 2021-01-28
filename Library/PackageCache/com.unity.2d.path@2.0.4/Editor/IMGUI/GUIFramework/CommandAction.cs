                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿using System;
using UnityEngine;

namespace UnityEditor.U2D.Path.GUIFramework
{
    public class CommandAction : GUIAction
    {
        private string m_CommandName;

        public Action<IGUIState> onCommand;

        public CommandAction(string commandName)
        {
            m_CommandName = commandName;
        }

        protected override bool GetTriggerContidtion(IGUIState guiState)
        {
            if (guiState.eventType == EventType.ValidateCommand && guiState.commandName == m_CommandName)
            {
                guiState.UseEvent();
                return true;
            }

            return false;
        }
        
    