                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              - // -----------------------------------------------------------------------
// <copyright file="SimpleLogItem.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace UnityEngine.U2D.Animation.TriangleNet
    .Logging
{
    using System;

    /// <summary>
    /// Represents an item stored in the log.
    /// </summary>
    internal class LogItem : ILogItem
    {
        DateTime time;
        LogLevel level;
        string message;
        string info;

        public DateTime Time
        {
            get { return time; }
        }

        public LogLevel Level
        {
            get { return level; }
        }

        public st