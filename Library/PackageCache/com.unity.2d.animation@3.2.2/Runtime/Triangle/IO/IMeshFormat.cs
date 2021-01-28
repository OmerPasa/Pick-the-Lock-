                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              	 // -----------------------------------------------------------------------
// <copyright file="IMeshFormat.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace UnityEngine.U2D.Animation.TriangleNet
    .IO
{
    using System.IO;
    using Animation.TriangleNet.Meshing;

    /// <summary>
    /// Interface for mesh I/O.
    /// </summary>
    internal interface IMeshFormat : IFileFormat
    {
        /// <summary>
        /// Read a file containing a mesh.
        /// </summary>
        /// <param name="filename">The path of the file to read.</param>
        /// <returns>An instance of the <see cref="IMesh" /> interface.</returns>
        IMesh Import(string filename);

        /// <summary>
        /// Save a mesh to disk.
        /// </summary>
        /// <param 