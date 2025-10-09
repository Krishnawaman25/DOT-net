namespace CdacBatchMarks
{

    internal class program
    { 
       static void Main(string[] arghs)
        {
            Console.WriteLine("Enter the  number of cdac batches:  ");
            int numberOfBatches = Convert.ToInt32(Console.ReadLine());

            //(assuming valid numerical input for simplicity as requested
            int[][] batchMarks = new int[numberOfBatches][];

            for (int i = 0; i<numberOfBatches ; i++)
            {
                Console.WriteLine($"Enter the number of students in Batch{i + 1}:");
                int studentsInBatch=Convert .ToInt32(Console.ReadLine());
                 

                batchMarks[i]=new int[studentsInBatch]


            }
        }
    }
    public class Class1
    {

    }
}
