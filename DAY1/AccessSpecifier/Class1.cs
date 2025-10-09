namespace AccessSpecifier
{
    public class BaseClass
    {
        int i;
        //default access specifier is 'private' for class members

        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;
    }
    public class DerivedClass: TestAccessSpecifier.BaseClass
    //:BaseClass
    {
        void DoNothing()
        {
            //this
        }
    }
    class Program
    {
        static void Main()
        {
            //BaseClass o1 = new BaseClass();
            //o1.


            TestAccessSpecifier.BaseClass o2 = new TestAccessSpecifier.BaseClass();

        }
    }


}
