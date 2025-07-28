using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    void Start()
    {
        string msg1 = "message";
        string msg2 = null;
        string msg3 = "";
        string msg4 = string.Empty;
        string name = "Coder Zero";
        //name[6] = 'B'; // 이렇게 안됨
        string str = name.Replace('Z', 'B');
        //Debug.Log(name + ',' + str); // string이 아니라 문자를
        char[] charArrays = name.ToCharArray(); // char형 배열로 바꾸는
        //Debug.Log(charArrays[1]);
        char[] carray = { 'A', 'B', 'C', ' ', 'd' };
        string s = new string(carray); // char형 배열을 string으로
        //Debug.Log(s);


        var sb = new StringBuilder();
        sb.Append(name);    // name의 값을 가지고 옴, 참조형이지만 값처럼 쓴다
        sb.Clear();
        sb.Append("Coder One");
        sb.Append(" Two");
        Debug.Log(sb.ToString());

        sb.Insert(6, "C");
        Debug.Log(sb);
        sb.Remove(6, 3); // 6번 자리 부터 3개를 지워라
        Debug.Log(sb);
        sb.Replace('C', 'I'); // C를 I로 바꿔라
        Debug.Log(sb);
        sb.Replace('o', 'O', 0, 11); // 0 ~ 11번 자리 중에 o를 O로 바꿔라
        Debug.Log(sb);
        

    }

    void Update()
    {
        
    }
}
