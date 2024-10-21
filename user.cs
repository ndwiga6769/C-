using System;

namespace myApplication 
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is " + age);
        }
    }
}