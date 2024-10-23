using System;

namespace Application
{
	class Car
    {
    string name = "Toyota V8 2016 Make";
    int price = 30_000;
    public void FullThrottle()
    	{
        Console.WriteLine("The car has been activated on full throttle mode");
        }
        
    static void Main()
        {
		Car Mazda = new Car();
        Mazda.FullThrottle();
        }
    }
}