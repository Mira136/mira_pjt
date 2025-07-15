using System;

namespace mira_pjt
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
            }
            Console.Read();
        }
    }
}

