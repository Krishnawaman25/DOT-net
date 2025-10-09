namespace OverloadingHidingAndOverriding
{

    internal class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
         //   o.display1(); //base
         //   o.display1("aa");  //derived
            o.display2(); //derived
            o.display3(); //derived
        }


        static void Main()
        {
            BaseClass o = new BaseClass();
            o.display2();  // not virtual-early binding/compile time binding
                           //depends on how ref has been declared
            o.display3();   //virtual-late/runtime binding
                            //depends on how memory has been allocated
            Console.WriteLine();

            o= new DerivedClass();
            o.display2();  // not virtual-early binding/compile time binding
                           //depends on how ref has been declared
            o.display3();   //virtual-late/runtime binding
                            //depends on how memory has been allocated
            Console.WriteLine();
            o = new SubDerivedClass();
            o.display2();  // not virtual-early binding/compile time binding
                           //depends on how ref has been declared
            o.display3();   //virtual-late/runtime binding
                            //depends on how memory has been allocated
            Console.WriteLine();
            //SubDerivedClass sb;
            DerivedClass obj= new SubSubDerivedClass();
            obj.display2();  // not virtual-early binding/compile time binding
                           //depends on how ref has been declared
            obj.display3();   //virtual-late/runtime binding
                            //depends on how memory has been allocated

        }
    }
    public class BaseClass
    {
        public void display1()
        {
            Console.WriteLine("Base Display1");
        }
        public void display2()
        {
            Console.WriteLine("base Display2");
        }
        public virtual void display3()
        {
            Console.WriteLine("base Display 3");
        }
    }
    public class DerivedClass : BaseClass
    {
        //overload the base class method
        //same func name,diff parameters
        //both methods are available thru object of derived class
        public void display1(string s)
        {
            Console.WriteLine("derived Display1"+s);
        }
        //hiding
        //same function name,same parameters
        //only derived method is avilabke through object of derived class
        public new void display2()
        {
            Console.WriteLine("derived Display2");

        }
        //overriding
        //same function name,same parameters
        //only derived method is available through object of derived class
        public override void display3()
        {
            Console.WriteLine("derived Display3");
        }

    }
    public class SubDerivedClass : DerivedClass
    {
        public override  void display3()
        {
            Console.WriteLine("Subderived display3");
        }
        
    }
    public class SubSubDerivedClass : SubDerivedClass
    {
        public override void display3()
        {
            Console.WriteLine("subsubderived display");
        }
    }
}
