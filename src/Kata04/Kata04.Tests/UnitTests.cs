using Xunit;

namespace CodeKata.Kata04.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Tests()
        {
            // Arrange

            // Act
            var weatherdata = DataMunging.GetSmallestSpread();

            // Assert
            Assert.Equal(14, weatherdata.Day);
            Assert.Equal(2, weatherdata.TemperaturSpread);
        }
    }
}
