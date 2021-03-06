                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                // -----------------------------------------------------------------------
// <copyright file="Edge.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace UnityEngine.U2D.Animation.TriangleNet
    .Geometry
{
    /// <summary>
    /// Represents a straight line segment in 2D space.
    /// </summary>
    internal class Edge : IEdge
    {
        /// <summary>
        /// Gets the first endpoints index.
        /// </summary>
        public int P0
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the second endpoints index.
        /// </summary>
        public int P1
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the segments boundary mark.
        /// </summary>
        public int Label
        {
            get;
            privat