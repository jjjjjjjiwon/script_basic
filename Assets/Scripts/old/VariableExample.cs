using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int globalNumber; // 전역 변수 , 초기화 필요없음, 기본값이 들어가있음
    
    void Start()
    {
        int localNumber = 0; // 지역 변수, 초기화 필요
        

        Console.WriteLine(globalNumber);
        Console.WriteLine(localNumber);

        int nyumber1;
        nyumber1 = 1;
        int number2 = 2;
        float number3 = 3.4f, number4 = 4f;

        // bool 식별자는 is~로 만드는게 암묵적인 룰
        bool isBool = true;
        bool isNotTrue = true;
        bool isover = false;

        Debug.Log(nyumber1);
        Debug.Log(nyumber1.ToString());
        Debug.Log(number3);
        Debug.Log(number3.ToString());
        Debug.Log(isNotTrue);
        Debug.Log(isNotTrue.ToString());

    }

}
