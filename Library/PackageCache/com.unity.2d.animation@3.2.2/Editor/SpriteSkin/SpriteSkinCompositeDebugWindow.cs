                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿#if ENABLE_ANIMATION_COLLECTION && ENABLE_ANIMATION_BURST
using UnityEngine;
using UnityEngine.U2D.Animation;

namespace UnityEditor.U2D.Animation
{
    internal class SpriteSkinCompositeDebugWindow : EditorWindow
    {
        [MenuItem("internal:Window/2D/SpritSkinCompositeDebug")]
        static void Launch()
        {
            EditorWindow.GetWindow<SpriteSkinCompositeDebugWindow>().Show();
        }

        Vector2 m_ScrollPos = Vector2.zero;
        string m_DebugLog = "";

     