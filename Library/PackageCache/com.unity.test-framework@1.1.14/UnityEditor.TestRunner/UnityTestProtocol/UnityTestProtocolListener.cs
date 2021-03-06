                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UnityTestProtocolListener : ScriptableObject, ICallbacks
    {
        private IUtpMessageReporter m_UtpMessageReporter;

        public UnityTestProtocolListener()
        {
            m_UtpMessageReporter = new UtpMessageReporter(new UtpDebugLogger());
        }

        public void RunStarted(ITestAdaptor testsToRun)
  