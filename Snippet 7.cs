﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sesson_4
{
    class Snippet_7
    {
        static void code7()
        {
            string input;
            Console.WriteLine("Enter the month");
            input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine("This month has 31 days");
                    break;
                case "APRIL":
                case "JUNE":
                case "SEPTEMBER":
                case "NOVEMBER":
                    Console.WriteLine("This month has 30 days");
                    break;
                case "FEBRUARY":
                    Console.WriteLine("This month has 28 day in a non-leap year and 29 days in a leap yaer");
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }
        }
    }
}
