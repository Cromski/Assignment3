using System;
using System.Collections.Generic;
using Xunit;
using static Assignment3.Extensions;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void flatten_given_12345n67_returns_1234567() 
        {
            //Arrange
            IEnumerable<int>[] xs = new int[][]{new []{1,2,3,4,5}, new []{6,7}};

            //Act
            IEnumerable<int> expected = new int[]{1,2,3,4,5,6,7};
            var actual = Extensions.Flatten(xs);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void filter_with_predicate_xmod7andGreaterThan42_given45n49n63n66n71n2345n55_returns_49n63n2345() 
        {
            //Arrange
            IEnumerable<int> ys = new int[]{45, 49, 63, 66, 71, 2345,55};

            //Act
            IEnumerable<int> actual =  ys.Filter((x) => x % 7 == 0 && x > 42);
            IEnumerable<int> expected = new int[]{49, 63, 2345};
            
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void filter_with_predicate_isLeapYear_given_44n400n100n1700n1800n1000n1600n2000_returns_44n400n1800n2000() 
        {
            //Arrange
            IEnumerable<int> ys = new int[]{44, 400, 100, 1700, 1800, 1000, 1600, 2000};

            //Act
            IEnumerable<int> actual =  ys.Filter((x) => x % 4 == 0 && (x % 100 != 0 || x % 400 == 0));
            IEnumerable<int> expected = new int[]{44,400,1600,2000};
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("https://github.itu.dk/BDSA2021/Assignment3", true)]
        [InlineData("http://github.itu.dk/BDSA2021/Assignment3", false)]
        public void isSecure_given_httpsURL_returns_true(string url, bool expected)
        {
            //Arrange
            Uri yep = new Uri(url);
    
            //Act
            bool actual = yep.IsSecure();
            
            //Assert
            Assert.Equal(expected, actual);

        }
        
        
        [Theory]
        [InlineData("This is a test for our regEx", 7)]
        [InlineData("Th1s 1s a t3st for 0ur regEx", 3)]
        public void WordCount_given_stringWith3Numbers_returns_3(string sentence, int expected)
        {
            //Act
            int actual = sentence.WordCount();
            
            //Assert
            Assert.Equal(expected, actual);

        }
        
    }
}
