using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment3
{
    public class Queries
    {

        private static IEnumerable<Wizard> wizards = Wizard.Wizards.Value;

        /*
            ASSIGNMENT 3.1
        */

        public static IEnumerable<object> GetWizardsByRowlingLINQ() 
        {
            var query = from wizard in wizards
                        where wizard.Creator == "Rowling"
                        select new {wizard.Name};

            return query;
        }

        public static IEnumerable<object> GetWizardsByRowling() 
        {
            var query = wizards.Where(w => w.Creator == "Rowling")
                               .Select(w => new {w.Name});
            
            return query;
        }

        /*
            ASSIGNMENT 3.2
        */

        public static int? GetFirstYearSithLordWasIntroducedLINQ() 
        {
            int? year = (
                from wizard in wizards
                where wizard.Name.StartsWith("Darth")
                orderby wizard.Year
                select new
                {
                    wizard.Year
                    
                }).First().Year;

            return year;
        }

        public static int? GetFirstYearSithLordWasIntroduced()
        {
            return wizards.Where(wiz => wiz.Name.StartsWith("Darth"))
                .OrderBy(wiz => wiz.Year)
                .First().Year;
        }

        /*
            ASSIGNMENT 3.3
        */
        public static object GetUniqueListOfHarryPotterWizardsLINQ() 
        {
            var query = from wizard in wizards
                        where wizard.Medium.StartsWith("Harry Potter")
                        group wizard by new {
                            wizard.Name,
                            wizard.Year
                        } into g
                        select new {
                            Name = g.Key.Name,
                            Year = g.Key.Year
                        };

            
            return query.Distinct();
        }

        public static object GetUniqueListOfHarryPotterWizard() 
        {
            var query = wizards.Where(wiz => wiz.Medium.StartsWith("Harry Potter"))
                               .GroupBy(wiz => new { wiz.Name, wiz.Year})
                               .Select(g => new {
                                    Name = g.Key.Name,
                                    Year = g.Key.Year
                               })
                               .Distinct();
            
            return query;
        }

        /*
            ASSIGNMENT 3.4
        */
        public static IEnumerable<string> GetWizardsByCreatorAndNameReversedLINQ() 
        {
            var query = from wizard in wizards
                        orderby wizard.Creator descending, wizard.Name descending
                        group wizard by wizard.Name into g
                        select new {
                            Name = g.Key
                        };

            foreach(var element in query) 
            {
                yield return element.Name;
            }    
        }

        public static IEnumerable<string> GetWizardsByCreatorAndNameReversed() 
        {
            var query = wizards.OrderByDescending(wiz => wiz.Creator)
                               .ThenByDescending(wiz => wiz.Name)
                               .GroupBy(wiz => wiz.Name)
                               .Select(wiz => new {
                                   Name = wiz.Key
                               });
            
            foreach(var element in query) 
            {
                yield return element.Name;
            }    
        }
    }
}
