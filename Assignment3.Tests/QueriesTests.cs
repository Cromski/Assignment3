using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void getWizardsByRowlingLINQ_given_WizardsValue()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;
            IEnumerable<object> expected = new List<object>{"Harry Potter", "Harry Potter", "Dumbledore"};
            IEnumerable<object> actual;

            //Act
            actual = Queries.getWizardsByRowling();

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
