using API.Controllers;
using API;
using FakeItEasy;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var doSomethingService = A.Fake<IDoSomethingService>();
            A.CallTo(() => doSomethingService.getMessage()).Returns("Hello testing world");
            var controller = new WeatherForecastController(doSomethingService);

            // Act
            var output = controller.Get();

            // Note; this is only for demo purposes, since test do not really test something
            // Assert
            Assert.Equal("Hello testing world", output);
        }
    }
}