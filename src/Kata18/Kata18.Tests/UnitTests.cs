using Xunit;

namespace CodeKata.Kata18.Tests
{
    public class UnitTests
    {
        [Fact]
        public void AddComponent()
        {
            // Arrange
            var dependencyTree = new DependencyTree();

            // Act
            dependencyTree.Add('A', new char[] { 'B', 'C' });

            // Assert
            Assert.Equal(1, dependencyTree.Count);
        }

        [Fact]
        public void ResolveNonExisting()
        {
            // Arrange
            var dependencyTree = new DependencyTree();
            dependencyTree.Add('A', new char[] { 'B', 'C' });
            dependencyTree.Add('B', new char[] { 'C', 'E' });
            dependencyTree.Add('C', new char[] { 'G' });
            dependencyTree.Add('D', new char[] { 'A', 'F' });
            dependencyTree.Add('E', new char[] { 'F' });
            dependencyTree.Add('F', new char[] { 'H' });

            var expectedResult = new char[] { };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('G');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
