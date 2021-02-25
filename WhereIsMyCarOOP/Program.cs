using System;

namespace WhereIsMyCarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("mark", "model", "123456", "blue");
            car.PrintCarInfo();
            while (car.DriveLap())
            {
                Console.WriteLine($"Car {car.Mark} drove a lap.");
            }
            car.PrintCarInfo();
        }
    }
}
