                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class FloatEqualityComparer : IEqualityComparer<float>
    {
        private const float k_DefaultError = 0.0001f;
        private readonly float AllowedError;

        private static readonly  FloatEqualityComparer m_Instance = new FloatEqualityComparer();
        public static FloatEq