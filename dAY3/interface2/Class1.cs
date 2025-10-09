namespace interface2
{

    internal class program
    {
        static void Main()
        {
            
                Class1 obj = new Class1();
                obj.Close();
                obj.Open();

            IFileFunctions oIFile;
            oIFile = obj;
            oIFile.Open();
            oIFile.Delete();

            IDbFunctions oIDb;
            oIDb = obj;
            oIDb.Delete();

            ((IFileFunctions)obj).Close();
            (obj as IFileFunctions).Open();
            
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }

    public class Class1:IDbFunctions, IFileFunctions
    {
        public void Close()
        {
            Console.WriteLine("Ifile.Close from class1");
        }
        void IDbFunctions.Delete()
        {
            Console.WriteLine("IDbFunctions.Delete from Class1");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Insert()
        {
            Console.WriteLine("Idb.insert from class1");
        }
        public void Open()
        {
            Console.WriteLine("Ifile.Open from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class1");
        }
        //void IFileFunctions.Close()
        //{
        //    Console.WriteLine("Ifile.Close from Class1");
        //}
        void IFileFunctions.Delete()
        {
            Console.WriteLine("Ifile.Delete from Class1");
        }
        //void IFileFunctions.Open()
        //{
        //    Console.WriteLine("Ifile.Open from Class1");
        //}
    }
}
