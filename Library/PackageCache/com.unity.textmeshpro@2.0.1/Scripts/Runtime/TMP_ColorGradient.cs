USBC�y:�     
* $�  �       V                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ﻿using UnityEngine;
using System.Collections;

namespace TMPro
{
    public enum ColorMode
    {
        Single,
        HorizontalGradient,
        VerticalGradient,
        FourCornersGradient
    }

    [System.Serializable]
    public class TMP_ColorGradient : ScriptableObject
    {
        public ColorMode colorMode = ColorMode.FourCornersGradient;

        public Color topLeft;
        public Color topRight;
        public Color bottomLeft;
        public Color bottomRight;

        const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient;
        static readonly Color k_DefaultColor = Color.white;

        /// <summary>
        /// Default Constructor which sets each of the colors as white.
        /// </summary>
        public TMP_ColorGradient()
        {
            colorMode = k_DefaultColorMode;
            topLeft = k_DefaultColor;
            topRight = k_DefaultColor;
            bottomLeft = k_DefaultColor;
            bottomRight = k_DefaultColor;
        }

        /// <summary>
        /// Constructor allowing to set the default color of the Color Gradient.
        /// </summary>
        /// <param name="color"></param>
        public TMP_ColorGradient(Color color)
        {
            colorMode = k_DefaultColorMode;
            topLeft = color;
            topRight = color;
            bottomLeft = color;
            bottomRight = color;
        }

        /// <summary>
        /// The vertex colors at the corners of the characters.
        /// </summary>
        /// <param name="color0">Top left color