using System;

namespace mira_pjt
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("* ");
                    else
                        Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
*
# *
* # *
# * # *
*/

