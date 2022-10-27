namespace OOPracticeTest
{
    using Xunit;

    public class Cartest
    {
        [Fact]
        public void Should_return_message_when_given_name_and_speed()
        {
            Car car = new Car("Cool Car", "30");

            string message = car.SpeedUp();

            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
