                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Layout;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal interface ITool {}

    internal abstract class BaseTool : SkinningObject, ITool
    {
        [SerializeField] 
        private LayoutOverlay m_LayoutOverlay;

        internal LayoutOverlay layoutOverlay
        {
            get
            {
                return m_LayoutOverlay;                
            }
        }

        [SerializeField]
        private bool m_IsActive = false;
        public bool isActive
        {
            get { return m_IsActive; }
            private set { m_IsActive = value; }
        }

        public virtual int defaultControlID { get { return 0; } }

        public virtual IMeshPreviewBehaviour previewBehaviour
        {
            get { return null; }
        }

        internal override void OnDestroy()
        {
            Deactivate();
        }

        public void Activate()
        {
            isActive = true;
            OnActivate();