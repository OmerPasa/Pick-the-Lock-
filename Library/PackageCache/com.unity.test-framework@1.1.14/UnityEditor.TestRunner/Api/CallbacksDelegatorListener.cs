                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }