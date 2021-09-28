using System;
using System.Linq;
using System.Collections.Generic;

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

        

    }
}
