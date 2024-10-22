using System;

namespace MyApplication
{
  class Program
  {
    static int addition(int x, int y)
    {
    return x + y;
    }
    static double addition(double x,double y)
    {
    return x + y;
    }
    static void Main(string[] args)
    {
    Console.WriteLine(addition(5, 67));
    Console.WriteLine(addition(5.67, 67.67));
    }
  }
}
