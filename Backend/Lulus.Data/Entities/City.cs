using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class City: BaseAttribute
    {
        public string Name { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<Province> Provinces { get; set; }
    }
}
