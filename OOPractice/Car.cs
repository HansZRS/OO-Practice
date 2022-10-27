using System;

namespace OOPracticeTest
{
    public class Driver
    {
        private Vehicle vehicle;

        public Driver(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string Speedup()
        {
            return vehicle.Message();
        }
    }

    public class Vehicle
    {
        private string name;
        private string speed;

        public Vehicle(string name, string speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Message()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }

    public class Car : Vehicle
    {
        public string Engine;

        public Car(string name, string speed) : base(name, speed)
        {
            if (Engine == "Oil")
            {
                speed = "30";
            }
            else
            {
                speed = "25";
            }
        }
    }

    public class Truck : Vehicle
    {
        public string Engine;
        public Truck(string name, string speed) : base(name, speed)
        {
        }
    }
}