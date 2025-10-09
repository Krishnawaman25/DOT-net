using System.Collections;

namespace Day5
{

    internal class program
    {
        static void Main1()
        {
            
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add(20);
            objArrayList.Add(10.234);
            objArrayList.Add(true);

            //ArrayList objArrayList2 = new ArrayList();
            //objArrayList2.Add(1);
            //objArrayList2.Add(2);
            //objArrayList2.Add(3);
            //objArrayList2.Add(456);

            //objArrayList.AddRange(objArrayList2);
            //objArrayList.Add(objArrayList2);

            //objArrayList.Insert(0, "inserted");
            //objArrayList.InsertRange(0, objArrayList2);

            //objArrayList.Remove(10); //object
            //objArrayList.RemoveRange(1, 2);

            //objArrayList.RemoveAt(0);
            //objArrayList.RemoveAt(1);
            //objArrayList.Clear();
            //to do -read up on cloning in .net
            //ArrayList o3 = (ArrayList)objArrayList.Clone();

            //bool isPresent = objArrayList.Contains("Vikram");
            //object[] arr = new object[objArrayList.Count];
            //objArrayList.CopyTo(arr);
            object[] arr2 = objArrayList.ToArray();
             ArrayList o3 = new ArrayList();
            o3.Add(100);
            //o3.Add(200);

            Console.WriteLine();
            //o3 = objArrayList.GetRange(1, 2);
            //objArrayList-- a, b, c, d, e
          //  o3 --x,y,z
            objArrayList.SetRange(1,o3);
           // objArrayList-- x,y,z, d, e
              objArrayList[0] = "changed values";
            Console.WriteLine();
           // objArrayList.this[0] = "changed Value";  //Concept of indexer
            Console.WriteLine();
            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( objArrayList.Count);
        }
        
    }
} 
