USBC���     
* 4   �       R                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEditor.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    internal class RequireApiProfileAttribute : NUnitAttribute, IApplyToTest
    {
        public ApiCompatibilityLevel[] apiProfiles { get; private set; }

        public RequireApiProfileAttribute(params ApiCompatibilityLevel[] apiProfiles)
        {
            this.apiProfiles = apiProfiles;
        }

        void IApplyToTest.ApplyToTest(Test test)
        {
            test.Properties.Add(PropertyNames.Category, string.Format("ApiProfile({0})", string.Join(", ", apiProfiles.Select(p => p.ToString()).OrderBy(p => p).ToArray())));
            ApiCompatibility