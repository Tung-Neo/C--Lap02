using System;
using System.Collections.Generic;
using System.Text;

namespace Sesson_4
{
    class Snippet_11
    {
        static void code()
        {
            int num;
            Console.WriteLine("Even Numbers");
            for(num = 1; num <= 11; num++)
            {
                if((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
