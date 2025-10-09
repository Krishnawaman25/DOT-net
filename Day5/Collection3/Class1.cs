using System.Collections;

namespace Collection3
{
    internal class program
    {
        static void Main()
        {
            //hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(6, "Himanshoo");
            objDictionary.Add(5, "Manish");
            objDictionary.Add(1, "Krushna");
            objDictionary.Add(2, "King");
            objDictionary.Add(3, "Raj");
            objDictionary.Add(4, "Samarth");
            //  objDictionary.Add(6,"Himanshu");//error -key must be unique

            //objDictionary[7] = "added"; //add if key not present
            //objDictionary[6] = "Himanshu"; //update if key present

            //objDictionary.Remove(7);//key
            //objDictionary.RemoveAt(7);//index

            foreach (DictionaryEntry item in objDictionary)
            {
                Console.WriteLine(item.Key + ":");
                Console.WriteLine(item.Value);
            }
                Console.WriteLine(objDictionary.GetByIndex(0));
                //gets value at index
                Console.WriteLine(objDictionary.GetKey(0));//get key at index
                IList keys = objDictionary.GetKeyList();
                IList values = objDictionary.GetValueList();
                Console.WriteLine(objDictionary.IndexOfKey(1)); //gets index from key
                Console.WriteLine(objDictionary.IndexOfValue("Manish"));//gets value at index
               objDictionary.SetByIndex(1, "Waman");
              // objDictionary.Keys;
             //  objDictionary.Values;   
             
            }
        }
    }

