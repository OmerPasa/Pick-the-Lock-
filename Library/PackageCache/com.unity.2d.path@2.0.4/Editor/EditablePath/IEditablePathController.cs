                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              	 ﻿using System;
using UnityEngine;

namespace UnityEditor.U2D.Path
{
    public interface IEditablePathController
    {
        IEditablePath editablePath { get; set; }
        IEditablePath closestEditablePath { get; }
        ISnapping<Vector3> snapping { get; set; }
        bool enableSnapping { get; set; }
        void RegisterUndo(string name);
        void ClearSelection();
        void SelectPoint(int index, bool select);
        void CreatePoint(int index, Vector3 position);
        void 