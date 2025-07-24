using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTimeExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log(default(DateTime)); // 나라별로 표기 방법이 다름 기본은  - 월/일/년
        Debug.Log(DateTime.Now);
        Debug.Log(DateTime.Now.Year);
        Debug.Log(DateTime.Now.Second);

        DateTime dt = new DateTime(2025, 07, 22, 15, 34, 05);
        Debug.Log(dt.Year);

        DateTime today = DateTime.Today;
        Debug.Log(today);

        DateTime tomorrow = today.AddDays(1);
        DateTime yesterday = today.AddDays(-1);

        DateTime dt1 = new DateTime(2018, 08, 1, 2, 3, 4);
        DateTime dt2 = new DateTime(2019, 10, 20, 12, 0, 5);

        TimeSpan timeSpan = dt2 - dt1;
        Debug.Log(timeSpan.Days);
        Debug.Log(timeSpan.TotalDays);
        Debug.Log(timeSpan.Hours);
        Debug.Log(timeSpan.TotalHours);

    }

    
}
