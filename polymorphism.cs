using System;
using MyApplication;

namespace MyApplication
{
        class Animal
        {
            pubublic virtual void animalSound()
            {
                Console.WriteLine("This is an animals Sound");
            }
        }

        class Pig : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The Pig says: wee wee")
            }
        }

        class Dog : Animal
        {
            public override void animalSound
            {
                Console.WriteLine("The dog barks: Wow Wow")
            }
        }

        class Program
        {
            public void Main(string[] args)
            {
                Animal myAnimal = new Animal();
                Animal myPig = new Pig();
                Animal myDog = new Dog();

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
            }
        }
}