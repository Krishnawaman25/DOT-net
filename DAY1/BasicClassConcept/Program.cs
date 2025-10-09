//using System;
//using payroll;

namespace BasicClassConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("HW");
            Class1 obj;
            obj = new Class1();
            Class1 obj2 = new Class1();
            obj2.Display();
            obj.Display();

            //positional parameters
            Console.WriteLine(obj.Add());
            Console.WriteLine(obj.Add(10));
            Console.WriteLine(obj.Add(10, 20));
            Console.WriteLine(obj.Add(10, 20, 30));

            //named parameters
            Console.WriteLine(obj.Add(a: 10, b: 20, c: 30));
            Console.WriteLine(obj.Add(c: 30));
            Console.WriteLine(obj.Add(10, c: 30));

        }
    }
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Display called");
        }
        //func overloading - same func name, diff parameters
        public void Display(string s)
        {
            Console.WriteLine("Display called " + s);
        }

        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Add(int a, int b, int c)
        //{
        //    return a + b +c;
        //}

        //instead of func overloading, use default parameters
        public int Add(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }
    }


    namespace payroll
    {
        public class Class1 { }
        public class Class2 { }
    }
    namespace cricketTeam
    {
        public class player();

        public class manager();

    }
    namespace manager
    {
        public class Employee();
        public class names();
    }
}