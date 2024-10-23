using System;

namespace myCar
{
    class Car:Vihecle
    {
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        Console.WriteLine( myCar.brand + " " + myCar.modelName );
    }
}