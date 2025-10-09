namespace dAY3
{


    internal class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.Display();
            //method 1-dirctly
            obj.Insert();
            obj.Update();
            obj.Delete();

            //method 2
            IDbFunctions oIDb;
            oIDb = obj;
            oIDb.Insert();
            oIDb.Update();
            oIDb.Delete();

            //method 3-implicit ref
            ((IDbFunctions)obj).Insert();
            //method 4-implicit ref
            (obj as IDbFunctions).Delete();


        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class Class1:IDbFunctions

    {
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from Class1");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from Class1");
        }
    }
}
