using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // uint a = 0b_0010_1101_0100_1111_0000_1111_0000_1100;
        // uint b = ~a;
        // Debug.Debug.Log(Convert.TOstring(b, ToBase:16));

        uint a = 0b_1100_1010;
        uint b = 0b_1101_1101;
        uint c = a & b;
        Debug.Debug.Log(Convert.TOstring(c, ToBase:16));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
