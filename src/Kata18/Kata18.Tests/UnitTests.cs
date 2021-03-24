using System;
using Xunit;

namespace CodeKata.Kata18.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var dependencyTree = new DependencyTree();
            dependencyTree.Add('A', new char[] { 'B', 'C' });
        }
    }
}
