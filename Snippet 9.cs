using System;
using System.Collections.Generic;
using System.Text;

namespace Sesson_4
{
    class Snippet_9
    {
        static void code9()
        {
            int i = 0;
            int j;
            while(i <= 5)
            {
                j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
