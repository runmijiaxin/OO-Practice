using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Driver
    {
        private Vehicle vehicle;
        public void Drive(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string SpeedUp()
        {
            return this.vehicle.SpeedUp();
        }
    }
}
