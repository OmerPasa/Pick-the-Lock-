                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿using System;
using UnityEngine;

namespace UnityEditor.U2D.Path.GUIFramework
{
    public class GenericDefaultControl : DefaultControl
    {
        public Func<IGUIState, Vector3> position;
        public Func<IGUIState, Vector3> forward;
        public Func<IGUIState, Vector3> up;
        public Func<IGUIState, Vector3> right;
        public Func<IGUIState, object> userData;

        public GenericDefaultControl(string name) : base(name)
        {
        }

        protected override Vector3 GetPosition(IGUIState guiState, int index)
        {
            if (position != null)
                return position(guiState);

            return base.GetPosition(guiState, index);
        }

        protected override Vector3 GetForward(IGUIState guiState, int index)
        {
            if (forward != null)
                return forward(guiState);

            return base.GetForward(guiState, index);
        }

        protected override Vector3 GetUp(IGUIState guiState, int index)
        {
            if (up != null)
                return up(guiState);

            return base.GetUp(guiSt