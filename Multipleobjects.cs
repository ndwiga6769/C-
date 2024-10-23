using System;

namespace MyApplication
{
class Car
	{
    string color = "Red";
    int price = 200000;
    
    static void Main(string[] args)
    	{
        Car benz = new Car();
        Car RangeRover = new Car();
        Console.WriteLine(benz.color);
        Console.WriteLine(RangeRover.price);
        }
    }
}