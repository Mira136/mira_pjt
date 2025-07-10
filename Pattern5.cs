using System;

namespace mira_bd
{
    class Pattern5
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = ++a + b++ + b++ + a++ + ++a + ++b + a++;
           // res = a;
           // a = a + 1;

            Console.WriteLine(res);
        }
    }
}
