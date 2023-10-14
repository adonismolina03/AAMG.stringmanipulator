using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAMG.StringManipulator.UnitTest.AppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_ShouldReverseString()
        {
            // Arrange
            string input = "Hello, World!";
            string expected = "!dlroW ,olleH";
            var manipulator = new StringManipulator();

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldRemoveSpaces()
        {
            // Arrange
            string input = "Hello, World!";
            string expected = "Hello,World!";
            var manipulator = new StringManipulator();

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
