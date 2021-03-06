                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Collections.Generic;
using NUnit.Framework.Interfaces;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public interface ITestAdaptor
    {
        string Id { get; }
        string Name { get; }
        string FullName { get; }
        int TestCaseCount { get; }
        bool HasChildren { get; }
        bool IsSuite { get; }
        IEnumerable<ITestAdaptor> Children { get; }
        ITestAdaptor Parent { get; }
        int Test