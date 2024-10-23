using System;

namespace MyApplication
{
  class Car 
    {
	string model;
    string color;
    int year;
    
  static void Main(string[] args)
  {
  	Car Mazda = new Car();
    Mazda.model = "Demio";
    Mazda.color = "Grey";
    Mazda.year = 2014;
    
    
    Car Dodge = new Car();
    Dodge.model = "Challenger";
    Dodge.color = "White";
    Dodge.year = 2018;
    
    
    Car Suzuki = new Car();
    Suzuki.model = "climber";
    Suzuki.color = "yellow";
    Suzuki.year = 2024;
    
    Console.WriteLine(Mazda);
    Console.WriteLine(Dodge.model);
    Console.WriteLine(Suzuki.model);
  }  
  }
}