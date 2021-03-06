                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEngine;

#if UNITY_2019_1_OR_NEWER
using UnityEngine.UIElements;
#else
using UnityEngine.Experimental.UIElements;
#endif

namespace UnityEditor.Collaboration
{
    internal class HistoryProgressSpinner : Image
    {
        private readonly Texture2D[] m_StatusWheelTextures;
        private bool m_ProgressEnabled;
        private IVisualElementScheduledItem m_Animation;

        public bool ProgressEnabled
        {
            set
            {
                if (m_ProgressEnabled == value)
                    return;

                m_ProgressEnabled = value;
                visible = value;


                if (value)
                {
                    if (m_Animation == null)
                    {
                        m_Animation = this.schedule.Execute(AnimateProgress).Every(33);
                    }
                    else
                    {
                        m_Animation.Resume();
                    }
                }
                else
                {
                    if (m_Animation != null)
                    {
                        m_Animation.Pause();
                    }
                }
            }
        }

        public HistoryProgressSpinner()
        {
            m_StatusWheelTextures = new Texture2D[12];
            for (int i = 0; i < 12; i++)
            {
                m_StatusWheelTextures[i] = EditorGUIU