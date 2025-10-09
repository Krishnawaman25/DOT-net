using System.Threading.Channels;

namespace DelegateExample
{
    public delegate int add(int a, int b);
    internal class program
    {
        //static void Main3()
        //{
        //    //del1 objDel = new del1(display);

        //    del1 objdel = display;
        //    objdel();

        //    objdel = show;
        //    objdel();

        //    Console.WriteLine();
        //    objdel += display;
        //    objdel();

        //    Console.WriteLine();
        //    objdel += show;
        //    objdel();

        //    Console.WriteLine();
        //    objdel += display;
        //    objdel();

        //    Console.WriteLine();
        //    objdel -= display;
        //    objdel();

        //    Console.WriteLine();
        //    objdel -= show;
        //    objdel();
        //}
        static void Main()
        {
            //{
            //    del1 objDel = (del1)Delegate.Combine(new del1(display), new del1(show), new del1(display));
            //        objDel();
            //    Console.WriteLine();
            //    objDel = (del1)Delegate.RemoveAll(objDel, new del1(display));
            //    objDel();
            //}
            //static void display()
            //{
            //    Console.WriteLine("display called");
            //}
            //static void show()
            //{
            //    Console.WriteLine("Hello i am krushna");
            //}
            add obj = add;
            Console.WriteLine(obj(4,3));
            static int add(int a, int b)
            {
                return a + b;
            }
            static void Display()
            {
                Console.WriteLine("Ddisplay calledd");
            }
            static void Show()
            {
                Console.WriteLine("show called");
            }
        }
    }
}
