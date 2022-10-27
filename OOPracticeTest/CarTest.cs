using OOPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOPracticeTest
{
    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_have_name_speed()
        {
            // given
            Car car = new Car("Cool Car", 30);
            // when
            string message = car.SpeedUp();
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
