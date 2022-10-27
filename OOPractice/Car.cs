using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Car
    {
        private string name;
        private int speed;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return this.name + ": speed up " + this.speed + " km/h";
        }
    }
}
