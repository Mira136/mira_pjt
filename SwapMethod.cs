using System;

namespace mira_pjt
{
    class SwapMethod
    {
        static void Swap(ref int a, ref int b) // a and b both are local variable
        {
            /* int temp = a;
            a = b;
            b = temp; */

            // Write another logic
            // a = 20,  b = 10
            a = a + b; // 30
            b = a - b;
            a = a - b;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swap : a = {0} and b = {1}",  a, b);
           // Swap(a, b); // passing the argument by value
            Swap(ref a, ref b); // passing the argument by reference
            Console.WriteLine("After swap : a = {0} and b = {1}", a, b);
        }
    }
}