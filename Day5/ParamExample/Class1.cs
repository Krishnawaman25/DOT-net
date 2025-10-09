using System.ComponentModel;

namespace ParamExample
{
internal class program
    {
        static void Main()
        {
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Add(10, 20, 30, 40, 50, 60, 70, 80, 90));

            static int Add(params int[] arr)
            {
                int sum = 0;
                foreach(int item in arr)
                {
                    sum += item;
                }
                return sum;
            }
        }
    }
}
