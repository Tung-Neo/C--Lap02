using System;
using System.Collections.Generic;
using System.Text;

namespace Sesson_4
{
    class Snippet_12
    {
        static void Main()
        {
            int rows = 2;
            int columns = 2;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write("{0}", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
