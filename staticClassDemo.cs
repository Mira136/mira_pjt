using System;

namespace mira_pjt
{
    // only required to be created any project

    static class MathMethods
    {
        //only static data members and static methods

        void Display()
        { }

        static void Show()
        { }
    }

    class StudentDetails
    {
        // only required to be created any project

        private StudentDetails() 
        {
            
        }
        public void Display()  //no benefit of adding non static methods because of private constructor
        { }

        static public void Show()  
        { }

    }

    class staticClassDemo
    {
        static void Main(string[] args)
        {
            //Trick - 1
            //1) You can not create an object of static class
            MathMethods obj2 = new MathMethods();
            //2) You can call static methods with class name
            MathMethods.Show();
            //3) You can not call non static methods with class name
            MathMethods.Display();

            //to create object of a classs
            //to call methods, constructors etc.
            //to assign values or calculate values for data members

            //Trick - 2
            //1) You can not create  an object of static class
            StudentDetails obj = new StudentDetails();
            //2) You can call static methods with class name
            StudentDetails.Show();    //only static methods can be called
            //3) You can not call non static methods with class name
            StudentDetails.Display();   //non static method 
        }
    }
}

//Que in Interview : how to stop creating project in class.

