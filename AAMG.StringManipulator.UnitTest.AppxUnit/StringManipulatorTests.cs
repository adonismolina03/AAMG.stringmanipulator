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
            var manipulator = new StringManipulator();

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal("!dlroW ,olleH", result);
        }

        [Fact]
        public void RemoveSpaces_ShouldRemoveSpaces()
        {
            // Arrange
            string input = "He llo, Wor ld!";
            var manipulator = new StringManipulator();

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("Hello,World!", result);
        }
    }
}
