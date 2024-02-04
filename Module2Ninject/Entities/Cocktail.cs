using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Entities
{
    public class Cocktail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Ingredients { get; set; }

        public string CountryOfInvention { get; set; }

        public int YearOfInvention { get; set; }
    }
}
