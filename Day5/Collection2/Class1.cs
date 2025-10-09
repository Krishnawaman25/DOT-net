using System.Collections;
using System.Net.Quic;

namespace Collection2
{
internal class program
    {
        static void Main()
        {
            ArrayList objArrayList = new ArrayList();
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");
            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Count}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity ={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count},Capacity={objArrayList.Capacity}");

            objArrayList.TrimToSize();
            Console.WriteLine($"after trim-count={objArrayList.Count},Capacity={objArrayList.Capacity}");

        }
    }
}
