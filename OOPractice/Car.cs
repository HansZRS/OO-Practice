using System;

namespace OOPracticeTest
{
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
        public Car(string name, string speed) : base(name, speed)
        {
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string name, string speed) : base(name, speed)
        {
        }
    }
}