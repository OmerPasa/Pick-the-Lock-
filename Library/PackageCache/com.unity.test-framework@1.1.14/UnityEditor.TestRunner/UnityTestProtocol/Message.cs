                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Diagnostics;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    [Serializable]
    internal abstract class Message
    {
        public string type;
        // Millisec