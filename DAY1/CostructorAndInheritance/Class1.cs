
namespace CostructorAndInheritance
{

    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no params cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("Base class no params cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no params cons");
            j = 20;
        }
            public DerivedClass(int i,int j):base(i)
        {
            Console.WriteLine("derived class int,int cons");
            this.j = j;
        }
    }

    internal class Program
    {
        static void Main()
        {
            DerivedClass o = new DerivedClass();
            DerivedClass o2 = new DerivedClass(40,50);
        }
    }
   
}
