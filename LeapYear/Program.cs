using System;

namespace LeapYear
{
    public class Year
    {
        public static void Main() { }

        public static bool IsLeapYear(int year) => year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }
}