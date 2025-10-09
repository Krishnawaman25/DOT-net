namespace defaultImplementattionofaInterface
{


    interface IMyInterface
    {
        void Method1();


        void Method2()
        {
            Console.WriteLine("Default implementation of method2 inside interface");
        }
    }
    class Myclass: IMyInterface
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implemented in class");

        }
        //Not implementing Method2() -iinterface default will be used
    }
    class program
    {
        static void Main()
        {
            IMyInterface obj = new Myclass();
            obj.Method1();   //Calls class implementtationm
            obj.Method2();   //Calls default implementation from interface
        }
    }
    
}
