                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                namespace UnityEngine.U2D.Animation.TriangleNet
    .Meshing
{
    using System.Collections.Generic;
    using Animation.TriangleNet.Topology;
    using Animation.TriangleNet.Geometry;

    /// <summary>
    /// Mesh interface.
    /// </summary>
    internal interface IMesh
    {
        /// <summary>
        /// Gets the vertices of the mesh.
        /// </summary>
        ICollection<Vertex> Vertices { get; }

        /// <summary>
        /// Gets the edges of the mesh.
        /// </summary>
        IEnumerable<Edge> Edges { get; }

        /// <summary>
        /// Gets the segments (constraint edges) of the mesh.
        /// </summary>
        ICollection<SubSegment> Segments { get; }

        /// <summary>
        /// Gets the triangles of the mesh.
        /// </summary>
        ICollection<Triangle> Triangles { get; }

        /// <summary>
        /// Gets the holes of the mesh.
        /// </summary>
        IList<Point> Holes { get; }

        /// <summary>
        /// Gets the bounds of the mesh.
        /// </summary>
        Rect