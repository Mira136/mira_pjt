using System;

namespace mira_bd
{
    class Pattern4
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10 ; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int ans = i * j;
                    Console.WriteLine(i + "*" + j + "=" + ans);
                }
                Console.WriteLine();
            }
        }
    }
}


