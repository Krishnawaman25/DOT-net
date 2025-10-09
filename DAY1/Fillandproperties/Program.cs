
namespace Fillandproperties
{
    internal class Program
    {

      
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.I = 20;
            Console.WriteLine(obj.I);

        }
    }

        public class Class1
        {
            private int i; //field
            public int I
            {
                set
                {
9                        i = value;
                    else
                        Console.WriteLine("Invalid Value");
                }
                get
                {
                    return i;
                }
            }

            private string prop1;
      
        public string Prop1
        {
            set { prop1 = value; }
            get { return prop1; }
        }
    }
}
