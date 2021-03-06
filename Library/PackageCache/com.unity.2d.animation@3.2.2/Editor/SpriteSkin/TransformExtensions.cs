                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D;

namespace UnityEditor.U2D.Animation
{
    internal static class TransformExtensions
    {
        public static Vector3 GetScaledRight(this Transform transform)
        {
            return transform.localToWorldMatrix.MultiplyVector(Vector3.right);
        }

        public static Vector3 GetScaledUp(this Transform transform)
        {
            return transform.localToWorldMatrix.Mul