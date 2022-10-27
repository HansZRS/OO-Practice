using System;

namespace OOPracticeTest
{
    public class Car
    {
        private string name;
        private string speed;

        public Car(string name, string speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}