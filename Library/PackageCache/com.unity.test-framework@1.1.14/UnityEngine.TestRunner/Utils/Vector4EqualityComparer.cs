
            var action = actions.FirstOrDefault(x => x.GetType() == typeof(TAction));

            if (action != null)
                return action.Execute(state, itemsDerived);

            return false;
        }

        public static bool Invoke<TAction>(WindowState state, T item)
            where TAction : ItemAction<T>
        {
            return Invoke<TAction>(state, new[] {item});
        }
    }
}
                                                                                                 using System.Collections.Generic;

namespace UnityEngine.TestTools.Utils
{
    public class Vector4EqualityComparer : IEqualityComparer<Vector4>
    {
        private const float k_DefaultError = 0.0001f;
        private readonly float AllowedError;

        private static readonly Vector4EqualityComparer m_Instance = new Vector4EqualityComparer();
        public static Vector4EqualityComparer Instance { get { return m_Instance; } }

        private Vector4EqualityComparer() : this(k_DefaultError) {}
        public Vector4EqualityComparer(float allowedError)
        {
            this.AllowedError = allowedError