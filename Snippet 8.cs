using System;
using System.Collections.Generic;
using System.Text;

namespace Sesson_4
{
    class Snippet_8
    {
        static void code8()
        {
            int num = 1;
            Console.WriteLine("Even Numbers");
            while (num <= 11)
            {
                if((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            }

        }
    }
}
