                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ( using System.Linq;
using UnityEditor.Build;

namespace UnityEditor.TestRunner
{
    // This class is invoked from native, during build
    internal class TestBuildAssemblyFilter : IFilterBuildAssemblies
    {
        private const string nunitAssemblyName = "nunit.framework";
        private const string unityTestRunnerAssemblyName = "UnityEngine.TestRunner";

  