n                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools.TestRunner.GUI;

namespace UnityEditor.TestTools.TestRunner.GUI
{
    [Serializable]
    internal class TestRunnerResult : TestRunnerFilter.IClearableResult
    {
        public string id;
        public string uniqueId;
        public string name;
        public string fullName;
        public ResultStatus resultStatus = ResultStatus.NotRun;
        public float duration;
        public string messages;
        public string output;
        public string stacktrace;
        public bool notRunnable;
        public bool ignoredOrSkipped;
        public string description;
        public bool isSuite;
        public List<string> categories;
        public string parentId;
        public string parentUniqueId;

        //This field is suppose to mark results from before domain reload
        //Such result is outdated because the code might haev changed
        //This field will get reset every time a domain reload happens
        [NonSerialized]
        public bool notOutdated;

        protected Action<TestRunnerResult> m_OnResultUpdate;

        internal TestRunnerResult(ITestAdaptor test)
        {
            id = test.Id;
            uniqueId = test.UniqueName;

            fullName = test.FullName;
            name = test.Name;
            description = test.Description;
            isSuite = test.IsSuite;

            ignoredOrSkipped = test.RunState == RunState.Ignored || test.RunState == RunState.Skipped;
            notRunnable = test.RunState == RunState.NotRunnable;

            if (ignoredOrSkipped)
            {
                messages = test.SkipReason;
            }
            if (notRunnable)
            {
                resultStatus = ResultStatus.Failed;
                messages = test.SkipReason;
            }
            categories = test.Categories.ToList();
            parentId = test.ParentId;
            parentUniqueId = test.ParentUniqueName;
        }

        internal TestRunnerResult(ITestResultAdaptor testResult) : this(testResult.Test)
        {
            notOutdated = true;

            messages = testResult.Message;
            output = testResult.Output;
            stacktrace = testResult.StackTrace;
            duration = (float)testResult.Duration;
            if (testResult.Test.IsSuite && testResult.ResultState == "Ignored")
            {
                resultStatus = ResultStatus.Passed;
            }
            else
            {
                resultStatus = ParseNUnitResultStatus(testResult.TestStatus);
            }
        }

        public void Update(TestRunnerResult result)
        {
            if (ReferenceEquals(result, null))
                return;
            resultStatus = result.resultStatus;
            duration = result.duration;
            messages = result.messages;
            output = result.output;
            stacktrace = result.stacktrace;
            ignoredOrSkipped = result.ignoredOrSkipped;
            notRunnable = result.notRunnable;
            description = result.description;
            notOutdated = result.notOutdated;
            if (m_OnResultUpdate != null)
                m_OnResultUpdate(this);
        }

        public void SetResultChangedCallback(Action<TestRunnerResult> resultUpdated)
        {
            m_OnResultUpdate = resultUpdated;
        }

        [Serializable]
        internal eUSBC���     
* zˀ  �       �noredOrSkipped = result.ignoredOrSkipped;
            notRunnable = result.notRunnable;
            description = result.description;
            notOutdated = result.notOutdated;
            if (m_OnResultUpdate != null)
                m_OnResultUpdate(this);
        }

        public void SetResultChangedCallback(Action<TestRunnerResult> resultUpdated)
        {
            m_OnResultUpdate = resultUpdated;
        }

        [Serializable]
        internal e
                    return ResultStatus.Inconclusive;
                case TestStatus.Skipped:
                    return ResultStatus.Skipped;
                default:
                    return ResultStatus.NotRun;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", name, fullName);
        