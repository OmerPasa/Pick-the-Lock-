                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class TestListenerWrapper : ITestListener
    {
        private readonly TestFinishedEvent m_TestFinishedEvent;
        private readonly TestStartedEvent m_TestStartedEvent;

        public TestListenerWrapper(TestStartedEvent