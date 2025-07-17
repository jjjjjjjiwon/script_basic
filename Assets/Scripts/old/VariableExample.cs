using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int globalNumber; // 전역 변수 , 초기화 필요없음, 기본값이 들어가있음
    
    void Start()
    {

        var hexLiteral = 0xaf; // 16진수
        var binaryLiteral = 0b_0000_0001; // 2진수 , _의미 없음 보기 편하라고

        // 최대 값, 최소값
        int mi = int.MaxValue;
        int ni = int.MinValue;

        bool b = default(bool);  // bool의 초기값은 false(0)

        string s1 = null;   // stringd의 초기값은 null이다
        string s2 = "";
        string s3 = string.Empty;

        // Nullabl - 참조형 형식이 아닌 변수에 null을 넣을수 있다, 입력이 없을때 사용가능
        int? ii = null;
        ii = 20;

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
