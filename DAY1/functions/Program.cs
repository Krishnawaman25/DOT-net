using System.ComponentModel;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 10);
            Console.WriteLine(result);
        }
        static int Add(int x,int y)
        {
            return x + y;
        }
    }
}
