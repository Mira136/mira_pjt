using System;

namespace mira_pjt
{
    /// <summary>
    /// This class includes important methods
    /// </summary>
    
    class SwapMethod
    {
        /// <summary>
        /// used to share % value
        /// </summary>
         
        int a;

        /// <summary>
        /// This method is used to swap values of two variables
        /// </summary>
        /// <param name="a"
        /// <param name="b"

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