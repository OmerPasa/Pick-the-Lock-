                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              	 /////////////////////////////////////////////////////////////////////////////////
//
// Photoshop PSD FileType Plugin for Paint.NET
// http://psdplugin.codeplex.com/
//
// This software is provided under the MIT License:
//   Copyright (c) 2006-2007 Frank Blumenberg
//   Copyright (c) 2010-2013 Tao Yue
//
// See LICENSE.txt for complete licensing and attribution information.
//
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using PDNWrapper;

namespace PhotoshopFile
{
    /// <summary>
    /// Stores the raw data for unimplemented image resource types.
    /// </summary>
    internal class RawImageResource : ImageResource
    {
        public byte[] Data { get; private set; }

        private ResourceID id;
        public override ResourceID ID
        {
            get { return id