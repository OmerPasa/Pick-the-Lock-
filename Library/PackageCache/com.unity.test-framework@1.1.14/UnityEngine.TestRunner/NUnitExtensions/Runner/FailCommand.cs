                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
using System.Collections;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class FailCommand : TestCommand, IEnumerableTestMethodCommand
    {
        private ResultState m_ResultState;
        private string m_Message;

        public FailCommand(Test test, ResultState resultState, string message)
            : base(test)
        {
    