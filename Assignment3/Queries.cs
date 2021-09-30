using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment3
{
    public class Queries
    {

        /*
            ASSIGNMENT 3.1
        */

        public static IEnumerable<object> GetWizardsByRowlingLINQ() {

            var wizards = Wizard.Wizards.Value;

            var query = from wizard in wizards
                        where wizard.Creator == "Rowling"
                        select new {Name = wizard.Name};

            return query;
        }

        public static IEnumerable<object> GetWizardsByRowling() {

            var wizards = Wizard.Wizards.Value;

            var query = wizards.Where(w => w.Creator == "Rowling")
                               .Select(w => new {Name = w.Name});
            
            return query;
        }

        /*
            ASSIGNMENT 3.2
        */

        public static int? GetFirstYearSithLordWasIntroducedLINQ() {

            var wizards = Wizard.Wizards.Value;

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

            var wizards = Wizard.Wizards.Value;

            return wizards.Where(wiz => wiz.Name.StartsWith("Darth"))
                .OrderBy(wiz => wiz.Year).First().Year;

            
        }

        /*
            ASSIGNMENT 3.3
        */

        public static object testtestse() {

            var wizards = Wizard.Wizards.Value;

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

            
            return query;
        }

        /*
            ASSIGNMENT 3.4
        */
        public static IEnumerable<string> GetWizardsByCreatorAndNameReversedLINQ() {

            var wizards = Wizard.Wizards.Value;

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

        public static IEnumerable<string> GetWizardsByCreatorAndNameReversed() {

            var wizards = Wizard.Wizards.Value;

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
