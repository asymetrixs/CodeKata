using Xunit;

namespace CodeKata.Kata04.Tests
{
    public class WeatherTests
    {
        [Fact]
        public void Tests()
        {
            // Arrange

            // Act
            var weatherdata = CodeKata.Kata04.Weather.WeatherData.GetSmallestSpread();

            // Assert
            Assert.Equal(14, weatherdata.Day);
            Assert.Equal(2, weatherdata.TemperaturSpread);
        }
    }
}
