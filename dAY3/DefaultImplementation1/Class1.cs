namespace DefaultImplementation1
{
    interface ILogger
    {
        void Log(string msg)
        {
            Console.WriteLine("Default Log:" + msg);
        }
    }

    class FileLogger : ILogger
    {
        //no need to override Log()
    }
    class Program
    {
        static void Main()
        {
            ILogger log = new FileLogger();
            log.Log("System started"); //use default method
        }
    }
}
