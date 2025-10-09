using System.Collections;
namespace Collections6
{
    internal class program
    {
       static void Main()
        {
            SortedList<int, Employee> objDictionary = new SortedList<int, Employee>();
            objDictionary.Add(1, new Employee { EmpNo = 1, Name = "Krushna" });
            objDictionary.Add(2, new Employee { EmpNo = 2, Name = "Saurabh" });

            foreach(KeyValuePair<int,Employee>item in objDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name);
            }

        }
       
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
        }
        



        
    }
}
