                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Linq;
using System.Text;

namespace UnityEngine.TestTools.Utils
{
    internal static class StackTraceFilter
    {
        private static readonly string[] s_FilteredLogMessages =
        {
            @"UnityEngine.DebugLogHandler:Internal_Log",
            @"UnityEngine.DebugLogHandler:Log",
            @"UnityEngine.Logger:Log",
            @"UnityEngine.Debug"
        };

        private static readonly string[] s_LastMessages =
        {
            @"System.Reflection.MonoMethod:InternalInvoke(Object, Object[], Exception&)",
            @"UnityEditor.TestTools.TestRunner.EditModeRunner:InvokeDelegator"
        };

        public static string Filter(string inputStackTrace)
        {
            int idx;
            foreach (var lastMessage in s_LastMessages)
            {
                idx = inputStackTrace.IndexOf(lastMessage);
                if 