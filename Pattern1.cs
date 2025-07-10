using System;

namespace mira_bd
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
            }
        }
    }
}