using System;

namespace mira_pjt
{
    class OutDemo
    {
        static void Change(ref int a, ref int b) 
        {
            a = 100;
            b = 200;
        }

        static void Update(out int x, out int y)
        {
            int t = x;
            x = 100; // 1st
            y = 200; // 2nd
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int x = 10, y = 20;

            Console.WriteLine("Before change : a = {0} and b = {1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After swap : a = {0} and b = {1}", a, b);

            Console.WriteLine("Before update : a = {0} and b = {1}", x, y);
            Update(out x, out y); // 1st and 2nd
            Console.WriteLine("After update : a = {0} and b = {1}", x, y);
        }
    }
}
