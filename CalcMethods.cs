// create  and create a method for addition,subtraction,multiplication,division
using System;

namespace mira_pjt
{
    class CalcMethods
    {

        //int test;  belongs to object, copies as per object
        //static int test2;  belongs class with single copy

        static int Add(int a, int b) // non static
        {
            return a + b;
            // cannot use non-static members within  static method
        }

        static int Sub(int a, int b) 
        {
            return a - b;
        }

        static int Mul(int a, int b) 
        {
            return a * b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }

        public static void Main(string[] args) // static
        {
            int a = 20, b = 10;
            int ra;

            ra = Add(a, b);
            Console.WriteLine("Addition : " + ra);
            ra = Sub(a, b);
            Console.WriteLine("Subtraction : " + ra);
            ra = Mul(a, b);
            Console.WriteLine("Multiplication : " + ra);
            ra = Div(a, b);
            Console.WriteLine("Division : " + ra);

        }
    }
}