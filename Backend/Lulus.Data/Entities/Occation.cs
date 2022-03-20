using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Occation:BaseAttribute
    {
        public string Name { get; set; }
        public virtual List<Product_Occation> Product_Occations { get; set; }
    }
}
