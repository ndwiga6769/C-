using System;
using AnApplication;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Challenger","Red", 2019);
            Car Toyota = new Car("Corolla","Blue", 2018);

            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.color);
        }

    }

}