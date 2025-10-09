namespace Nullabletypes
{
   internal class Program
    {
        static void Main1()
        {
            int? i = 10;
            i = null;
            int j;
            if (i != null)
            {
                j = (int)i;
            }
            else
            {
                j = 0;
                if (i.HasValue)
                    j = i.Value;
                else
                    j = 0;
                j = i.GetValueOrDefault();
                j = i.GetValueOrDefault(5);

                j = i ?? 0; //null Colesence Operator
                Console.WriteLine(j);
            }
            static void Main()
            {
                //nullable reference type
                string? s;
                s = Console.ReadLine()!;//sinple line suppreess
                s = Console.ReadLine();
            
            }
            }

        }
    }

