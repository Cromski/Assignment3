using System;
using System.IO;
using Xunit;
using Assignment3;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        [Theory]
        [InlineData(" 0042", 42, true)]
        [InlineData("54", 54, true)]
        [InlineData(" 66 ", 66, true)]
        [InlineData(" 66 ", 65, false)]
        public void Delegates_Number_Equality_Returns_Correct_Value(string text, int number, bool expected) {

            Assert.Equal(Delegates.NumberEqualityOperation(text, number), expected);
        }
        
        [Fact]
        public void PrintReverseString_given_yesthisisinreverse_returns_esrevernisisihtsey()
        {
            //Arrange
            string input = "yesthisisinreverse";
            var actual = new StringWriter();
            Console.SetOut(actual);
            
            //Act
            string expected = "esrevernisisihtsey";
            Delegates.PrintReverseString(input);
            var actuallyActual = actual.GetStringBuilder().ToString().Trim();
            //Assert
            Assert.Equal(expected, actuallyActual);
        }
    }
}
