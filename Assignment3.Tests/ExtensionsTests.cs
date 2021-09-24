using System;
using System.Collections.Generic;
using Xunit;
using static Assignment3.Extensions;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void flatten_given_xs_returns_() 
        {
            //Arrange
            IEnumerable<int>[] xs = new int[][]{new []{1,2,3,4,5}, new []{6,7}};

            //Act
            IEnumerable<int> expected = new int[]{1,2,3,4,5,6,7};
            var actual = Extensions.Flatten(xs);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
