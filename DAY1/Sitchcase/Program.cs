namespace Sitchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day Number (1-7):");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday");break;
                case 3: Console.WriteLine("tuesday");break;
                default:Console.WriteLine("Invalid day");
                    break;

            }
        }
    }
}
