using System;

namespace mira_pjt
{
    class Employee1
    {
        int EmpID;
        string Name;
        string City;
        public Employee1()
        {
        }
        public Employee1(int EmpID, string Name)
        {
            this.EmpID = EmpID;
            this.Name = Name;
        }
        public Employee1(int EmpID, string Name, string City) : this(EmpID, Name)
        {
            this.City = City;
        }
        public void Display()
        { }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Employee1 obj1 = new Employee1();
            Employee1 obj2 = new Employee1(101, "Mira", "Rajkot");
            Console.ReadKey();
        }
    }
