                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿using System;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Events;

namespace UnityEditor.U2D
{

    internal class SpriteShapeAnalyticsEvents
    {
        public class SpriteShapeEvent : UnityEvent<UnityEngine.U2D.SpriteShape> { }
        public class SpriteShapeRendererEvent : UnityEvent<SpriteShapeRenderer> { }

        private SpriteShapeEvent m_SpriteShape = new SpriteShapeEvent();
        private SpriteShapeRendererEvent m_SpriteShapeRenderer = new SpriteShapeRendererEvent();

        public virtual SpriteShapeEvent spriteShapeEvent { get { return m_SpriteShape; } }
        public virtual SpriteShapeRendererEvent spriteShapeRendererEvent { get { return m_SpriteShapeRenderer; } }
    }

    [Serializable]
    enum SpriteShapeAnalyticsEventType
    {
        SpriteShapeProfileCreated = 0,
        SpriteShapeRendererCreated = 1
    }

    [Serializable]
    struct SpriteShapeAnalyticsEvent
    {
        [SerializeField]
        public SpriteShapeAnalyticsEventType sub_type;
        [SerializeField]
        public string data;
    }

    internal interface ISpriteShapeAnalyticsStorage
    {
        AnalyticsResult SendUsageEvent(SpriteShapeAnalyticsEvent evt);
        void Dispose();
    }

    internal static class SpriteShapeAnalyticConstant
    {
        public const int k_MaxEventsPerHour = 1000;
        public const int k_MaxNumberOfElements = 1000;
    }

    [Serializable]
    internal class SpriteShapeAnalytics
    {
        const int k_SpriteShapeEventElementCount = 2;
        ISpriteShapeAnalyticsStorage m_AnalyticsStorage;
        [SerializeField]
        SpriteShapeAnalyticsEvents m_EventBus = null;

        internal SpriteShapeAnalyticsEvents eventBus
        {
            get
            {
                if (m_EventBus == null)
                    m_EventBus = new SpriteShapeAnalyticsEvents();
                return m_EventBus;
            }
        }

        public SpriteShapeAnalytics(ISpriteShapeAnalyticsStorage analyticsStorage)
        {
            m_AnalyticsStorage = analyticsStorage;
            eventBus.spriteShapeEvent.AddListener(OnSpriteShapeCreated);
            eventBus.spriteShapeRendererEvent.AddListener(OnSpriteShapeRendererCreated);
        }

        public void Dispose()
        {
            eventBus.spriteShapeEvent.RemoveListener(OnSpriteShapeCreated);
            eventBus.spriteShapeRendererEvent.RemoveListener(OnSpriteShapeRendererCreated);
            m_AnalyticsStorage.Dispose();
        }        

        void OnSpriteShapeCreated(UnityEngine.U2D.SpriteShape shape)
        {
            SendUsageEvent(new SpriteShapeAnalyticsEvent()
            {
                sub_type = SpriteShapeAnalyticsEventType.SpriteShapeProfileCreated,
                data = ""
            });
        }

        void OnSpriteShapeRendererCreated(SpriteShapeRenderer renderer)
        {
            SendUsageEvent(new SpriteShapeAnalyticsEvent()
            {
                sub_type = SpriteShapeAnalyticsEventType.SpriteShapeRendererCreated,
                data = ""
            });
        }

        public void SendUsageEvent(SpriteShapeAnalyticsEvent evt)
        {
            m_AnalyticsStorage.SendUsageEvent(evt);
        }

    }

    // For testing.
    internal class SpriteShapeJsonAnalyticsStorage : ISpriteShapeAnalyticsStorage
    {
        [Serializable]
        struct SpriteShapeToolEvents
      USBC�y:�     
* z�   �       �  {
                sub_type = SpriteShapeAnalyticsEventType.SpriteShapeRendererCreated,
                data = ""
            });
        }

        public void SendUsageEvent(SpriteShapeAnalyticsEvent evt)
        {
            m_AnalyticsStorage.SendUsageEvent(evt);
        }

    }

    // For testing.
    internal class SpriteShapeJsonAnalyticsStorage : ISpriteShapeAnalyticsStorage
    {
        [Serializable]
        struct SpriteShapeToolEvents
      
            {
                string file = string.Format("analytics_{0}.json", System.DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
                if (System.IO.File.Exists(file))
                    System.IO.File.Delete(file);
                System.IO.File.WriteAllText(file, JsonUtility.ToJson(m_TotalEvents, true));
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
            }
            finally
            {
                m_TotalEvents.events.Clear();
            }
        }
    }

    [InitializeOnLoad]
    internal class SpriteShapeUnityAnalyticsStorage : ISpriteShapeAnalyticsStorage
    {
        const string k_VendorKey = "unity.2d.spriteshape";
        const int k_Version = 1;

        public