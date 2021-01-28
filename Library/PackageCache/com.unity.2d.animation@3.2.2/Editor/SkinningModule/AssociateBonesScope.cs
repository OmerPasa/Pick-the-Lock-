                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class AssociateBonesScope : IDisposable
    {
        private bool m_Disposed;
        private bool m_AssociateBones;
        private SpriteCache m_Sprite;

        public AssociateBonesScope(SpriteCache sprite)
        {
            m_Sprite = sprite;
            m