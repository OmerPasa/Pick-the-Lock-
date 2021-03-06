                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEngine;
using UnityEngine.U2D.Animation;

namespace UnityEditor.U2D.Animation
{
    internal interface IBoneGizmoToggle
    {
        bool enableGizmos { get; }
        void OnGUI();
    }

    internal class BoneGizmoToggle : IBoneGizmoToggle
    {
        private bool m_EnableGizmos;
        private bool m_CurrentEnableGizmoState;

        public bool enableGizmos
        {
            get { return m_CurrentEnableGizmoState; }
        }

        public BoneGizmoToggle()
        {
            SpriteSkin.onDrawGizmos.AddListener(OnDrawGizmos);
        }

        ~BoneGizmoToggle()
        {
            SpriteSkin.onDrawGizmos.RemoveListener(OnDrawGizmos);
        }

        //This callback will be called before OnSceneGUI in a Repaint event
        private void OnDrawGizmos()
        {
            m_EnableGizmos = true;

            //One time is enough
            SpriteSkin.onDrawGizmos.RemoveListener(OnDrawGizmos);
        }

        public void OnGUI()
        {
            //Ignore events other than Repaint
     