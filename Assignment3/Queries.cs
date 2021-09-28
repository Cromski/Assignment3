using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Assignment3
{
    public class Queries
    {
        public static IEnumerable<object> getWizardsByRowlingLINQ() {

            var wizards = Wizard.Wizards.Value;

            var query = from wizard in wizards
                        where wizard.Creator == "Rowling"
                        select new {Name = wizard.Name};

            return query;
        }

        public static IEnumerable<object> getWizardsByRowling() {

            var wizards = Wizard.Wizards.Value;

            var query = wizards.Where(w => w.Creator == "Rowling")
                               .Select(w => new {Name = w.Name});
            
            return query;
        }

        public static int? getyep() {

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

        public static int? yeppp()
        {

            var wizards = Wizard.Wizards.Value;

            return wizards.Where(wiz => wiz.Name.StartsWith("Darth"))
                .OrderBy(wiz => wiz.Year).First().Year;

            
        }
        
        
        
        
        
    }
}
