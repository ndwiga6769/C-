using System;

namespace myApplication
{
    // abstarct class 
    abstract class Animal
    {
        // abstract method that does not have the body
        public abstract void animalSound();

        public void Sleep()
        {
        Console.WriteLine("Zzz")
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee")
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.Sleep();
    }
}