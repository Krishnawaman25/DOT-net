
using System;

namespace ExplicitInterface
{
    interface IFile
    {
        void Open();
    }
    interface IDatabase
    {
        void Open();
    }
    class SystemManager:IFile,IDatabase
    {
        //Explicit implementation
        void IFile.Open()
        {
            Console.WriteLine("File opened.");
        }
        void IDatabase.Open()
        {
            Console.WriteLine("Database opened.");
        }
    }
    class Program
    {
        static void Main()
        {
            SystemManager sys = new SystemManager();


            IFile f = sys;
            f.Open();

            IDatabase d = sys;
            d.Open();
        }
    }
}
