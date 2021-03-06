                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEngine.TestTools.Logging;
using UnityEngine.TestTools.Utils;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnhandledLogMessageException : ResultStateException
    {
        public LogEvent LogEvent;
        private readonly string m_CustomStackTrace;

        public UnhandledLogMessageException(LogEvent log)
            : base(BuildMessage(log))
        {
            LogEvent = log;
            m_Custo