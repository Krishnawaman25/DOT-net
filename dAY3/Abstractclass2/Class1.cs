namespace Abstractclass2
{
    public abstract class Animal
    {
        // Abstaract method (no body)
        public abstract void Makesound();


        //Normal method with body
        public void Eat()
        {
            Console.WriteLine("Animal is Eating...");
        }
    }

    public class Dog : Animal
    {
        // Must Override abstract method
        public override void Makesound()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal a = new Dog();
            a.Makesound();
            a.Eat();
        }
    }
}
