                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿namespace UnityEngine.U2D
{
    public class SplineUtility
    {
        public static float SlopeAngle(Vector2 start, Vector2 end)
        {
            Vector2 dir = start - end;
            dir.Normalize();
            Vector2 dvup = new Vector2(0, 1f);
            Vector2 dvrt = new Vector2(1f, 0);

            float dr = Vector2.Dot(dir, dvrt);
            float du = Vector2.Dot(dir, dvup);
            float cu = Mathf.Acos(du);
            float sn = dr >= 0 ? 1.0f : -1.0f;
            float an = cu * Mathf.Rad2Deg * sn;

            // Adjust angles when direction is parallel to Up Axis.
            an = (du != 1f) ? an : 0;
            an = (du != -1f) ? an : -180f;
            return an;
        }
        public static void CalculateTangents(Vector3 point, Vector3 prevPoint, Vector3 nextPoint, Vector3 forward, float scale, out Vector3 rightTangent, out Vector3 leftTangent)
        {
            Vector3 v1 = (prevPoint - point).normalized;
            Vector3 v2 = (nextPoint - point).normalized;
            Vector3 v3 = v1 + v2;
            Vector3 cross = forward;

            if (prevPoint != nextPoint)
            {
                bool colinear = Mathf.Abs(v1.x * v2.y - v1.y * v2.x + v1.x * v2.z - v1.z * v2.x + v1.y * v2.z - v1.z * v2.y) < 0.01f;

                if (colinear)
                {
                    rightTangent = v2 * scale;
                    leftTangent = v1 * scale;
                    return;
                }

                cross = Vector3.Cross(v1, v2);
            }

            rightTangent = Vector3.Cr