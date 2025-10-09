namespace Inheritance
{
    public class BaseClass
    {
        public int i;
    }
    public class  DerivedClass:BaseClass
    {
        public int j;
    }
    internal class Program
    {
        static void Main()
        {
            DerivedClass o = new DerivedClass();
        }
    }
}
