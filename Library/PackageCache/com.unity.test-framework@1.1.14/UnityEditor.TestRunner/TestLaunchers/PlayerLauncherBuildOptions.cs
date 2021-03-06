                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Text;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PlayerLauncherBuildOptions
    {
        public BuildPlayerOptions BuildPlayerOptions;
        public string PlayerDirectory;

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("locationPathName = " + BuildPlayerOptions.locationPathName);
            str.AppendLine("target = " + BuildPlayerOptions.target);
            str.AppendLine("scenes = " + string.Join(", ", BuildPlayerOptions.scenes));
            str.AppendLine("asset