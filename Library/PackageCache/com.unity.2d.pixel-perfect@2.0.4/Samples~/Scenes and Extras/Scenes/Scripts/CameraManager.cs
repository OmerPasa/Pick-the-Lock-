USBC0���     
* 3�  �       \337a5-fed4-404d-89a1-ecfd3ef689a9</rdf:li> <rdf:li>xmp.did:78529456-93c4-0841-9a50-c895bc044068</rdf:li> <rdf:li>xmp.did:df9f5f61-4049-2647-b975-def9b5a6d130</rdf:li> </rdf:Bag> </photoshop:DocumentAncestors> </rdf:Description> </rdf:RDF> </x:xmpmeta> <?xpacket end="r"?>�k�  �IDATH��VQ�� ����to�W����t�D�#5������^��4��oX�����D�= �)9vIv���Y�vÃ�6�gp���o��Y�c7|��n���NN���t�4����# d gm�*�8dp��<�A�7P5�r)��^u�XC��e���E����ɟ�,�j	�R�-V�~ܖ,���Jgtg�S﻿using System;
using UnityEngine;
using UnityEngine.U2D;

public class CameraManager : MonoBehaviour
{
    public Camera ordinaryCamera;
    public PixelPerfectCamera pixelPerfectCamera;

    private bool isPixelPerfect;

    void Awake()
    {
        isPixelPerfect = false;
        ValidateCameras(isPixelPerfect);
    }

 