using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    // field
    static public bool staticVariable = true; // 정적 변수
    int globalVariable = 1;     // 전역 변수

    public int PublicValue = 1;
    public int pv2 = 4;
    public bool isPublic = false;

    void Start()
    {
        int localVariable = 1;      // 지역 변수
        int localVariable2;
        // Debug.Log(localVariable2); // 초기화
        LocalVariable(1);
        Debug.Log(pv2);
    }

    void LocalVariable(int parameter)
    {
        float localVariable = parameter;
    }

}
