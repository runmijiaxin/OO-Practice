using OOPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOPracticeTest
{
    public class TruckTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_truck_have_name_speed()
        {
            // given
            Truck truck = new Truck("Big Truck", 10);
            // when
            string message = truck.SpeedUp();
            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
