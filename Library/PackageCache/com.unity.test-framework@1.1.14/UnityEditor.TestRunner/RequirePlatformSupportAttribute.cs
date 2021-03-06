                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEditor.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class RequirePlatformSupportAttribute : NUnitAttribute, IApplyToTest
    {
        public RequirePlatformSupportAttribute(params BuildTarget[] platforms)
        {
            this.platforms = platforms;
        }

        public BuildTarget[] platforms { get; private set; }

        void IApplyToTest.ApplyToTest(Test test)
        {
            test.Properties.Add(PropertyNames.Category, string.Format("RequirePlatformSupport({0})", string.Join(", ", platforms.Select(p => p.ToString()).OrderBy(p => p).ToArray())));

            if (!platforms.All(p => BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.Unknown, p)))
