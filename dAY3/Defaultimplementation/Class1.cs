namespace DefaultImplementationInterfaces1
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            //method 1 - select not available

            //select available with method 2/3/4
            //def imp code will be called
            (o as IDbFunctions).Select();

        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("def implementation of Select");
        }
    }
    public class Class1 : IDbFunctions
    {

        public void Delete()
        {
            Console.WriteLine("Idb.Delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class1");
        }
    }
}

namespace DefaultImplementationInInterfaces2
{
    internal class Program
    {
        static void Main2()
        {
            Class1 o = new Class1();
            //method 1 - select available
            //select also available with method 2/3/4
            //class1 code will be called

            o.Select();

            (o as IDbFunctions).Select();

        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("def implementation of Select");
        }
    }
    public class Class1 : IDbFunctions
    {

        public void Delete()
        {
            Console.WriteLine("Idb.Delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class1");
        }
        public void Select()
        {
            Console.WriteLine("Idb.Select from class1");
        }
    }
}

namespace DefaultImplementationInInterfaces3
{
    internal class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            o.Insert();
            //o.Select(); //not available
            (o as IDbFunctions).Select(); //method 4 works calls class1 code


        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("def implementation of Select");
        }
    }
    public class Class1 : IDbFunctions
    {

        public void Delete()
        {
            Console.WriteLine("Idb.Delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class1");
        }
        //use explicit impl if there is ambiguity (multiple interfaces having the same method)
        void IDbFunctions.Select()
        {
            Console.WriteLine("Idb.Select from class1");
        }
    }
}