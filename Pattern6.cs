using System;

namespace mira_pjt
{
    class Pattern6
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0 || j == 2 || i == 0 || i == n)
                    {
                        Console.Write(n + " ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


/* 
3 3 3
3 1 3 
3 2 3
3 3 3

4 4 4
4 1 4
4 2 4
4 3 4
4 4 4 
*/