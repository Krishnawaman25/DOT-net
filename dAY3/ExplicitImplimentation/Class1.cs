namespace ExplicitImplimentation
{
    interface IFile
    {
        void Open();
    }
    interface IDatabase
    {
        void Open();
    }
    class SystemManager : IFile, IDatabase
    {
        void IFile.Open()
        {
            Console.WriteLine("File opened.");
        }
        void IDatabase.Open()
        {
            Console.WriteLine("Database opened");
        }

    }


    class Program
    {
        static void Main()
        {
            SystemManager sys = new SystemManager();
            //system.open() Not allowed
            IFile f = sys;
            f.Open();  //file open
            IDatabase d = sys;
            d.Open();   //Database changed
        }
    }
}
