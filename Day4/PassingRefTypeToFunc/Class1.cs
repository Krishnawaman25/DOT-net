using System.Runtime.Remoting;

namespace PassingRefTypeToFunc
{
  internal class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.i = 100;
            //DoSomthing1(obj)
            //DoSomething2(obj)
            //Dosomethjing3(ref obj)
            //DoSomething4(out obj)
            DoSomething5(in obj);
            Console.WriteLine(obj.i);
            }

        
        static void DoSomething1(Class1 o2)
        {
            o2.i = 200;
        }
        static void DoSomething2(Class1 o2)
        {
            o2 = new Class1();
            o2.i = 200;
        }
        static void DoSomething3(ref Class1 o2)
        {
            o2 = new Class1();
            o2.i = 200;
        }
        static void DoSomething4(out Class1 o2)
        {
            o2 = new Class1();
            o2.i = 200;
        }
        static void DoSomething5(in Class1 o2)
        {
            o2.i = 200;
        }
        public class Class1
        {
            public int i;
        }
        
    }
}
