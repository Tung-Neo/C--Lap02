using System;
using System.Collections.Generic;
using System.Text;

namespace Sesson_4
{
    class Snippet_4
    {
        static void code4()
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;
            if(yrsOfService < 5)
            {
                if(salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus amount: " + bonus);
        }
    }
}
