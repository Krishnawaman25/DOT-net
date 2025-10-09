namespace defaultInterface
{
    interface I1
    {
        void Show()
        {
            Console.WriteLine("I1 Show");
        }
    }


    interface I2
    {
        void Show()
        {
            Console.WriteLine("I2 Show");
        }
    }
    class Demo : I1, I2
    {
        void I1.Show() => Console.WriteLine("I1 show claeed");
        void I2.Show() => Console.WriteLine("I2 show called");

    }
    class Program
    {
        static void Main()
        {
            Demo d = new Demo();
            ((I1)d).Show(); //I1 Show Called
            ((I2)d).Show(); //I2 Show caleed
        }
    }
}