namespace ImplicitImplementation1
{
    interface Icar
    {
        void Start();
    }
    class Tesla : Icar
    {
        public void Start()
        {
            Console.WriteLine("Tesla started.");
        }
    }
    class program
    {
        static void Main()
        {
            Tesla t = new Tesla();
            t.Start();
        }
    }
}
