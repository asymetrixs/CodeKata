using Xunit;

namespace CodeKata.Kata04.Tests
{
    public class SoccerTests
    {
        [Fact]
        public void TestParse()
        {
            // Arrange

            // Act
            var data = Soccer.SoccerLeagueTable.ParseData();

            // Assert
            Assert.Equal("Arsenal", data[0].Name);
            Assert.Equal(79, data[0].AgainstOpponent);
            Assert.Equal(36, data[0].ForOpponent);
        }

        [Fact]
        public void TestDifference()
        {
            // Arrange
            var data = Soccer.SoccerLeagueTable.ParseData();

            // Act
            var soccerDifference = Soccer.SoccerLeagueTable.GetNameOfTeamWithSmallestGoalDifference(data);

            // Assert
            Assert.Equal("Arsenal", soccerDifference);
        }
    }
}
