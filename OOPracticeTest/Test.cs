namespace OOPracticeTest
{
    using Xunit;

    public class Test
    {
        [Fact]
        public void Should_return_message_when_given_carname_and_speed()
        {
            Car car = new Car("Cool Car", "30", "oil");

            string message = car.Message();

            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_given_truckname_and_speed()
        {
            Truck truck = new Truck("Bad Truck", "10");

            string message = truck.Message();

            Assert.Equal("Bad Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_spped_up_given_driver_a_car()
        {
            Driver driver = new Driver(new Car("Cool Car", "30"));

            string message = driver.Speedup();

            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_spped_up_given_driver_a_truck()
        {
            Driver driver = new Driver(new Car("Bad Truck", "10"));

            string message = driver.Speedup();

            Assert.Equal("Bad Truck: speed up 10 km/h", message);
        }
    }
}
