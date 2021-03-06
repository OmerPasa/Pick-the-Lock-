                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System;
using Unity.Collections;
using UnityEngine;

namespace UnityEditor.U2D.PSD
{
    [Serializable]
    class PSDLayer
    {
        [SerializeField]
        string m_Name;
        [SerializeField]
        string m_SpriteName;
        [SerializeField]
        bool m_IsGroup;
        [SerializeField]
        int m_ParentIndex;
        [SerializeField]
        string m_SpriteID;
        [SerializeField]
        int m_LayerID;
        [SerializeField]
        Vector2Int m_MosaicPosition;

        [NonSerialized]
        GameObject m_GameObject;

        public PSDLayer(NativeArray<Color32> tex, int parent, bool group, string layerName, int width, int height, int id)
        {
            isGroup = group;
            parentIndex = parent;
            texture = tex;
            name = layerName;
            this.width = width;
            this.height = height;
            layerID = id;
        }

        public int layerID { get { return m_LayerID; } private set { m_LayerID = value; } }

        public string name { get { return m_Name; } private set { m_Name = value; } }
        public string spriteName { get { return m_SpriteName; } set { m_SpriteName = value; } }
        public bool isGroup { get { return m_IsGroup; } private set { m_IsGroup = value; } }
        public int parentIndex { get { return m_ParentIndex; } private set { m_ParentIndex = value; } }
        public Vector2Int mosaicPosition { get { return m_MosaicPosition; } set { m_MosaicPosition = value; 