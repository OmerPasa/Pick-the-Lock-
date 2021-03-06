                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Timeline
{
    /// <summary>
    /// Used to indicate path and priority of classes that are auto added to the menu
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class MenuEntryAttribute : Attribute
    {
        public readonly int priority;
        public readonly string name;
        public readonly string subMenuPath;

        public MenuEntryAttribute(string path, int priority)
     