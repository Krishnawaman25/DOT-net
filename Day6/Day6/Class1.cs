namespace Day6
{
   internal class program
    {
        static void Main1()
        {
            Action o1 = display;
            o1();

            Action<string> o2 = display;
            o2("aaa");


            Action<string, int> o3 = display;
            o3("aaa", 10);
        }
       

        static void display()
        {
            Console.WriteLine("Display called");
        }
        static void display(string s)
        {
            Console.WriteLine("Display called"+s);
        }
        static void display(string s ,int i)
        {
            Console.WriteLine("Display called"+s+i);
        }
        static void Main()
        {
            Func<string> o1 = GetTime;
            Console.WriteLine(o1());

            Func<int, int> o2 = GetDouble;
            Console.WriteLine( o2(10));

            Func<int, int> o3= GetDouble;
            Console.WriteLine(o3(10));


        }

        static bool IsBasicGreaterThan10000(Employee obj)
        {
            if (obj.Basic > 10000)
            {
                return true;
            }
            return false;
        }
        static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }


        static int GetDouble(int a)
        {
            return a * 2;
        }



        static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }


}

