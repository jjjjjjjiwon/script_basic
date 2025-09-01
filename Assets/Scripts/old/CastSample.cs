using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using UnityEngine;

public class CastSample : MonoBehaviour
{
    void Start()
    {
        // int n1 = 1;
        // float f1 = n1;
        // float x = 1.234f;
        // int a = (int)x;
        // byte[] bytes = { 0, 1, 2, 34 };
        // int  i = BitConverter.ToInt32(bytes, 0);

        string s1 = "12345";
        int i1 = default(int);
        bool result =int.TryParse(s1, out i1);
        Debug.Log(i1);
        Debug.Log($"try parse: {result}, i1: {i1}");

        string s2 = "123.45";
        float f2 = float.Parse(s2);
        Debug.Log(f2);
            }

    
}
