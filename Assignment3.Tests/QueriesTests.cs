using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        /*
            Assignment 3.1
        */
        [Fact]
        public void Queries_getWizardsByRowlingLINQ_given_WizardsValue()
        {
            //Arrange
            IEnumerable<object> expected = new []{
                new {Name = "Harry Potter"}, 
                new {Name = "Harry Potter"}, 
                new {Name = "Dumbledore"}
            };

            IEnumerable<object> actual;

            //Act
            actual = Queries.GetWizardsByRowlingLINQ();

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Queries_getWizardsByRowling_given_WizardsValue()
        {
            //Arrange
            IEnumerable<object> expected = new []{
                new {Name = "Harry Potter"}, 
                new {Name = "Harry Potter"}, 
                new {Name = "Dumbledore"}
            };
            IEnumerable<object> actual;

            //Act
            actual = Queries.GetWizardsByRowling();

            //Assert
            Assert.Equal(expected, actual);
        }

        /*
            Assignment 3.2
        */
        [Fact]
        public void Queries_get_first_sith_lord_returns_1977() 
        {
            Assert.Equal(1977, Queries.GetFirstYearSithLordWasIntroduced());
        }

        [Fact]
        public void Queries_get_first_sith_lord_returns_1977_LINQ() 
        {
            Assert.Equal(1977, Queries.GetFirstYearSithLordWasIntroducedLINQ());
        }

        /*
            Assignment 3.3
        */
        [Fact]
        public void Queries_get_unique_harry_potter_wizars_name_and_year_returns_correctly()
        {
            //Arrange
            IEnumerable<object> expected = new []{
                new {Name = "Harry Potter", Year = 2002}, 
                new {Name = "Harry Potter", Year = 2005}, 
                new {Name = "Dumbledore", Year = 2002}
            };

            IEnumerable<object> actual;

            //Act
            actual = Queries.GetUniqueListOfHarryPotterWizard();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Queries_get_unique_harry_potter_wizars_name_and_year_returns_correctly_LINQ()
        {
            //Arrange
            IEnumerable<object> expected = new []{
                new {Name = "Harry Potter", Year = 2002}, 
                new {Name = "Harry Potter", Year = 2005}, 
                new {Name = "Dumbledore", Year = 2002}
            };

            IEnumerable<object> actual;

            //Act
            actual = Queries.GetUniqueListOfHarryPotterWizardsLINQ();

            //Assert
            Assert.Equal(expected, actual);
        }

        /*
            Assignment 3.4
        */
        [Fact]
        public void Queries_get_wizards_by_reverse_order_returns_correctly() 
        {
            string[] expected = {
                "The Flash",
                "Batman",
                "Iron Man",
                "Captain America",
                "Sauron",
                "Gandalf",
                "Frodo",
                "Harry Potter",
                "Dumbledore",
                "Luke Skywalker",
                "Darth Vader",
                "Darth Snoke",
            };

            Assert.Equal(expected, Queries.GetWizardsByCreatorAndNameReversed());
        }

        [Fact]
        public void Queries_get_wizards_by_reverse_order_returns_correctly_LINQ() 
        {
            string[] expected = {
                "The Flash",
                "Batman",
                "Iron Man",
                "Captain America",
                "Sauron",
                "Gandalf",
                "Frodo",
                "Harry Potter",
                "Dumbledore",
                "Luke Skywalker",
                "Darth Vader",
                "Darth Snoke",
            };

            Assert.Equal(expected, Queries.GetWizardsByCreatorAndNameReversedLINQ());
        }  
    }
}
