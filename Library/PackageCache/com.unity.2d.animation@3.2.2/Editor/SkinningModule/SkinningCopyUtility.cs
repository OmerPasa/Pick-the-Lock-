                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                namespace UnityEditor.U2D.Animation
{
    internal static class SkinningCopyUtility
    {
        private static ISkinningSerializer s_SkinningSerializer = new SkinningSerializerJSON();
        public static ISkinningSerializer Serializer
        {
            get { return s_SkinningSerializer; }
            set { s_SkinningSerializer = value; }
        }

        public static string SerializeSkinningCopyDataToString(SkinningCopyData skinningData)
        {
            return s_SkinningSerializer.Serialize(skinningData);
        }

        public static bool CanDeserializeSystemCopyBufferToSkinningCopyData()
        {
            if (!string.IsNullOrEmpty(EditorGUIUti