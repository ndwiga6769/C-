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

// we can also call a method with a default argument we use the = operator and we pass it in the argument section
using System;

namespace MyApplication
{
  class Program
  {
  static void Name(string country = "kenya by default")
    {
    Console.WriteLine("My country is " + country);
    }
  static void Main(string[] args)
  	{
    Name("Uganda");
    Name();
    }
  }
}