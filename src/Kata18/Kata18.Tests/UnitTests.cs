using Xunit;

namespace CodeKata.Kata18.Tests
{
    public class UnitTests
    {
        private DependencyTree _dependencyTree;

        public UnitTests()
        {
            this._dependencyTree = new DependencyTree();
            this._dependencyTree.Add('A', new char[] { 'B', 'C' });
            this._dependencyTree.Add('B', new char[] { 'C', 'E' });
            this._dependencyTree.Add('C', new char[] { 'G' });
            this._dependencyTree.Add('D', new char[] { 'A', 'F' });
            this._dependencyTree.Add('E', new char[] { 'F' });
            this._dependencyTree.Add('F', new char[] { 'H' });
        }

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
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('G');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void ResolveA()
        {
            // Arrange
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { 'B', 'C', 'E', 'F', 'G', 'H' };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('A');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ResolveB()
        {
            // Arrange
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { 'C', 'E', 'F', 'G', 'H' };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('B');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ResolveC()
        {
            // Arrange
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { 'G' };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('C');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ResolveD()
        {
            // Arrange
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { 'A', 'B', 'C', 'E', 'F', 'G', 'H' };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('D');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ResolveE()
        {
            // Arrange
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { 'F', 'H' };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('E');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ResolveF()
        {
            // Arrange
            var dependencyTree = _dependencyTree;
            var expectedResult = new char[] { 'H' };

            // Act
            var actualResult = dependencyTree.ResolveDependenciesOf('F');

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
