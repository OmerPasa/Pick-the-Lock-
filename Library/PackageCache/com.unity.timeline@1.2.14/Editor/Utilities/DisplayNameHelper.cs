                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Text;
using UnityEngine.Playables;

namespace UnityEditor.Timeline
{
    static class DisplayNameHelper
    {
        static readonly string k_NoAssetDisplayName = L10n.Tr("<No Asset>");
        static readonly string k_ReadOnlyDisplayName = L10n.Tr("[Read Only]");
        static readonly StringBuilder k_StringBuilder = new StringBuilder();

        public static string GetDisplayName(ISequenceState sequence)
        {
            string displayName = sequence.director != null ? GetDisplayName(sequence.director) : GetDisplayName(sequence.asset);
            if (sequence.asset != null && sequence.isReadOnly)
                displayName += " " + k_ReadOnlyDisplayName;
            return displa