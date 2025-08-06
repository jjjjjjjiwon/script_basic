using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
    [Flags]
    enum Day { Sunday = 0, Monday = 1, Thuesday = 2, Wedensday = 4, Thursday = 8, Friday = 16, Saturday = 32 };
    
    enum month : byte { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Dec, Nov };
    void Start()
    {
        Day today = Day.Wedensday;
        int dayNumber = (int)today;
        Debug.LogFormat("{0} is day number {1}.", today, dayNumber);
        month thisMonth = month.Aug;
        byte monthNumber = (byte)thisMonth;
        Debug.LogFormat("{0} is month number {1}.", thisMonth, monthNumber);


        Day workingDay = Day.Monday | Day.Thuesday | Day.Wedensday | Day.Thursday | Day.Friday ;
        Debug.LogFormat($"working days are {workingDay}");
    }

}
