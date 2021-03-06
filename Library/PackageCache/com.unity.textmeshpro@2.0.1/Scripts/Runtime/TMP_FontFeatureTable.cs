                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;


namespace TMPro
{
    /// <summary>
    /// Table that contains the various font features available for the given font asset.
    /// </summary>
    [Serializable]
    public class TMP_FontFeatureTable
    {
        /// <summary>
        /// List that contains the glyph pair adjustment records.
        /// </summary>
        internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
        {
            get { return m_GlyphPairAdjustmentRecords; }
            set { m_GlyphPairAdjustmentRecords = value; }
        }
        [SerializeField]
        internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

        /// <summary>
        /// 
        /// </summary>
        internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;

        // =============================================
        // Constructor(s)
        // =============================================

        public TMP_FontFeatureTable()
        {
            m_GlyphPairAdjustmentRecords = new List<TMP_GlyphPairAdjustmentRecord>();
            m_GlyphPairAdjustmentRecordLookupDictionary = new Dictionary<long, TMP_GlyphPairAdjustmentRecord>();
        }

        // =============================================
        // Utility Functions
        // ====================