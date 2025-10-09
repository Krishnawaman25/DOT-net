namespace ImplicitImplimentation
{
  interface IFile
    {
        void Open();
    }
    class FileManager:IFile
    {
        //Implicit implementation
        public void Open()
        {
            Console.WriteLine("File Opened");
        }
    }
    class program
    {
        static void Main()
        {
            FileManager f = new FileManager();
            f.Open();  //Direct access
        }
    }
}
