using System.Runtime.InteropServices;
using System.Reflection;
namespace collection5
{
  internal class program
    {
        static void Main()
        {
            List<int> o = new List<int>();
            o.Add(1);
            foreach(int item in o)
            {
                Console.WriteLine(item);
            }
            List<String> o2 = new List<string>();
            o2.Add("aa");
            List<Employee> o3 = new List<Employee>();
            o3.Add(new Employee { EmpNo = 1, Name = "krushna" });
           foreach(Employee item in o3)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
    }
}
class Employee
{
    public int EmpNo { get; set; }
    public string Name { get; set; }
}

