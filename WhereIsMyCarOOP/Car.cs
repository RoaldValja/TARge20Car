using System;
using System.Collections.Generic;
using System.Text;

namespace WhereIsMyCarOOP
{
    class Car
    {
        private string markName;
        private string modelName;
        private string registrationNumber = string.Format("{0, 6}", "");
        private string color;
        private int odometer;
        private int fuelTank;
        public Car(string markName, string modelName, string registrationNumber, string color)
        {
            if(registrationNumber.Length > 6)
            {
                throw new ArgumentException("Registration number was bigger than 6 characters.");
            }
            this.markName = markName;
            this.modelName = modelName;
            this.registrationNumber = registrationNumber;
            this.color = color;
            odometer = 0;
            fuelTank = 60;
        }
        public string Model
        {
            get
            {
                return modelName;
            }
        }
        public string Mark
        {
            get
            {
                return markName;
            }
        }
        public string Registration
        {
            get
            {
                return registrationNumber;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
        }
        public int Odometer
        {
            get
            {
                return odometer;
            }
        }
        public int FuelTank
        {
            get
            {
                return fuelTank;
            }
        }
        public bool StopDrive()
        {
            Console.WriteLine($"Car {Mark} stops.");
            return false;
        }
        public bool DriveLap()
        {
            if(fuelTank == 0)
            {
                return StopDrive();
            }
            odometer += 100;
            fuelTank -= 5;
            return true;
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Car mark: {Mark}");
            Console.WriteLine($"Car model: {Model}");
            Console.WriteLine($"Car registration number: {Registration}");
            Console.WriteLine($"Car color: {Color}");
            Console.WriteLine($"Car odometer: {Odometer}");
            Console.WriteLine($"Car fuel tank: {FuelTank}");
        }
    }
}
