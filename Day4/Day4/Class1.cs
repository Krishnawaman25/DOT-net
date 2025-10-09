namespace RefAndValueTypes
{
    internal class Program
    {
        //static void Main()
        //{
        //    Class1 o1 = new Class1();
        //    Class1 o2 = new Class1();
        //    o1.i = 100;
        //    o2.i = 200;
        //    o1 = o2;
        //    o1.i = 300;
        //    Console.WriteLine(o1.i);
        //    Console.WriteLine(o2.i);
        //}
        static void Main()
        {
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1 = o2;
            o2 = 300;
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        //static void Main()
        //{
        //    string o1, o2;
        //    o1 = "100";
        //    o2 = "200";
        //    o1 = o2;
        //    o2 = "300";
        //    Console.WriteLine(o1);
        //    Console.WriteLine(o2);
        //    Console.ReadLine();
        //}
    }
    //200,300
    //300,300

    public class Class1
    {
        public int i;
    }
}