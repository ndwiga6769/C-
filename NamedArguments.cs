using System;

namespace MyApplication
{
  class Program
  {
    static void Children(string child1, string child2, string child3)
    {
    Console.WriteLine("The youngest child is " + child3);
    Console.WriteLine("The middle child is " + child2);
    Console.WriteLine("The eldest child is " + child1);
    }
    static void Main(string[] args)
    {
    Children (child3:"Viola", child1:"Danwycliff", child2:"Grace");
    }
  }
}