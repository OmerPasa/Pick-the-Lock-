                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
    {
        private const float k_DefaultError = 0.00001f;
        private readonly float AllowedError;

        private static readonly QuaternionEqualityComparer m_Instance = new QuaternionEqualityComparer();
        public static QuaternionEqualityComparer Instance { get { return m_I