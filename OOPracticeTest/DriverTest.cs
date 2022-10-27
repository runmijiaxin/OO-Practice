using OOPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace OOPracticeTest
{
    public class DriverTest
    {
        [Fact]
        public void Should_show_message_when_speed_up_given_car()
        {
            // given
            Car car = new Car("Cool Car", 30);
            Driver driver = new Driver();
            // when
            driver.Drive(car);
            string message = driver.SpeedUp();
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
