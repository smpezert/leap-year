﻿using System;

namespace LeapYear
{
    public class Year
    {
        public static void Main() { }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year != 1700)
            {
                return true;
            }
            return false;
        }
    }
}