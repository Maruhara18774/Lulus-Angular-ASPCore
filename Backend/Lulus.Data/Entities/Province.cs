using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Province:BaseAttribute
    {
        public string Name { get; set; }
        public int CityID { get; set; }
        public virtual City City { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
