                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class ColorEqualityComparer : IEqualityComparer<Color>
    {
        private const float k_DefaultError = 0.01f;
        private readonly float AllowedError;


        private static readonly ColorEqualityComparer m_Instance = new ColorEqualityComparer();
        public static ColorEqualityComparer Instance { get { return m_Instance; } }

        private ColorEqualityComparer() : this(k_DefaultError)
        {
        }

        public ColorEqualityComparer(float error)
        {
            this.AllowedError = error;
        }

        public bool Equals(Colo