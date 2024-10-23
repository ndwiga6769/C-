using System;

namespace MyApplication
{
  // create a class
  class Car
  {
  // create a public field that can be accesed by another file
  public string model;
  
  // create a class constructor for the car class
  public Car()
  	{
    model = "Mustang"; // set the initial value for the car
    }
  static void Main(string[] args)
  	{
    Car Mustang = new Car();
   
    Console.WriteLine(Mustang.model);
    }
  }
}