using System;

namespace myApplication
{
	class Program
    {
    static void Names(string firstName,string lastName, int age)
    	{
        Console.WriteLine("My Name is " + firstName + " " + lastName + " I am " + age + " Years old");
        }
    static void Main(string[] args)
    {
    Names("GraceKalen", "Ndwiga", 20);
    Names("Danwycliff", "Njoka", 25);
    Names("Viola","Ndwiga", 18);
    }
    }
}