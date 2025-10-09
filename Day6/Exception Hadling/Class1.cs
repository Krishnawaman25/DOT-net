using System.Threading.Channels;

namespace Exception_Hadling
{
    internal class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj = null;
            int x = Convert.ToInt32(Console.ReadLine());
            obj.P1 = 100 / x;
            Console.WriteLine(obj.P1);
        }

        static void Main1()
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");

            }
            catch
            {
                Console.WriteLine("Exception  occured");
            }
            Console.WriteLine("code after try");

        }

        static void Main2()
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBException occured");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("NRException occured");
            }
            catch (FormatException)
            {
                Console.WriteLine("formatException occured");
            }
            Console.WriteLine("Code after try");
        }
        static void Main3()
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            //catch (SystemException ex)
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occured");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("code after try");
        }

        static void Main4()
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occured");
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("NRException occured");
            }
            //catch (DivideByZeroException ex) 
            //catch (ArithmeticException ex) 
            //catch (SystemException ex) //base class exception has to caught after derived class exceptions
            //{
            //    Console.WriteLine("DBException occurred");
            //}
            //catch (Exception ex) //catches all unhandled exceptions
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally runs when Exception does not occur, 
            //or Exception occurs and is handled or 
            //Exception occurs and is NOT handled 
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("after try");
        }
         static void Main5()
        {
            Class1 obj = new Class1();
            try
            {
                //obj=null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch(FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occured.Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");

                }
                finally
                {
                    Console.WriteLine("Nested try finally example");
                }
            }
        }
    }
        public class Class1
        {
            private int p1;
            public int P1
            {
                get { return p1; }
                set
                {
                    p1 = value;
                }
            }
        }
    }

