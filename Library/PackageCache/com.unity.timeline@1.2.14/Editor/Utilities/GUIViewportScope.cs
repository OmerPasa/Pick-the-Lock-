                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using UnityEngine;

namespace UnityEditor
{
    // Special Clip Scope that only effects painting, and keeps the coordinate system identical
    struct GUIViewportScope : IDisposable
    {
        bool m_open;
        public GUIViewportScope(Rect position)
        {
        