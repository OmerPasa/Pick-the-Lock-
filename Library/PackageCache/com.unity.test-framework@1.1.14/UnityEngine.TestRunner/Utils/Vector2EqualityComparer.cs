                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector2EqualityComparer : IEqualityComparer<Vector2>
    {
        private const float k_DefaultError = 0.0001f;
        private readonly float AllowedError;

        private static readonly Vector2EqualityComparer m_Instance = new Vector2EqualityComparer();
        public static Vector2EqualityComparer Instance { get { return m_Instance; } }

        private Vector2EqualityCompar