using System.Collections;
namespace Collection4
{
    internal class program
    {
    static void Main()
        {
            Stack s = new Stack();
            s.Push("aa");
            Console.WriteLine(s.Peek());//read it but do not remove from stack
           Console.WriteLine(s.Pop());//get the value and remove from the stack

            Queue q = new Queue();
            q.Enqueue("hello");
            Console.WriteLine(q.Peek()); //read it but do not remove from the stack
             Console.WriteLine(q.Dequeue());//get the value and remove from the stack
        }
    }
    
}
