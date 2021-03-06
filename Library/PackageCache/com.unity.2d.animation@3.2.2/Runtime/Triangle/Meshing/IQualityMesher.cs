                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               namespace UnityEngine.U2D.Animation.TriangleNet
    .Meshing
{
    using Animation.TriangleNet.Geometry;

    /// <summary>
    /// Interface for polygon triangulation with quality constraints.
    /// </summary>
    internal interface IQualityMesher
    {
        /// <summary>
        /// Triangulates a polygon, applying quality options.
        /// </summary>
        /// <param name="polygon">The polygon.</param>
        /// <param name="quality">Quality options.</param>
        /// <returns>Mesh</returns>
        