using System;

namespace mira_pjt
{
    class MthdOverLoadingDemo
    {
        void Sum(int x, int y, int z)
        {
            Console.WriteLine("Sum: " + (x + y + z));
        }
        void Sum(int x, float y, int z)
        {
            Console.WriteLine("Sum: " + (x + y + z));
        }
        static void Main()
        {
            MthdOverLoadingDemo obj = new MthdOverLoadingDemo();

            obj.Sum(10, 20, 30);          
            obj.Sum(10, 20.5f, 30);          
        }
    }
}
