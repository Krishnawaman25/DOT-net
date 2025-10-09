
namespace Objectinitializers
{
    internal class Program
    {
        static void Main(String[] args) {



            Class1 o1 = new Class1();
            o1.Prop1 = 1;
            o1.Prop2 = 2;
            o1.Prop3 = 3;

            //object initializer-use only if constructor option is not available
            //shortens the code,does not make it run faster
            Class1 o2 = new Class1() { Prop1 = 1, Prop2 = 2, Prop3 = 3 };
            Class1 o3 = new Class1 { Prop1 = 1, Prop2 = 2, Prop3 = 3 };

            //  Class1 o4 = new Class1(1, 2) { Prop3 = 3 };
            //  Class1 o5 = new Class1(10, 20, 30) { Prop1 = 1, Prop2 = 2, Prop3 = 3 }; ----do not do this -horrible code

            Console.WriteLine(o1.Prop1);
            Console.WriteLine(o2.Prop2);
            Console.WriteLine(o3.Prop3);
        }



    }

    public class Class1
    {
        private int prop1;
        public int Prop1
        {
            set
            {
                if (value <= 100)
                {
                    prop1 = value;
                }
                else
                {
                    Console.WriteLine("invalid Value");
                }
            }
            get
            {
                return prop1;
            }

        } 
        public int Prop2 { get; set; }
         public int Prop3 { get; set; }
         
    }
}
