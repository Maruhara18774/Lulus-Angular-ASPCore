using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class ProductImage:BaseAttribute
    {
        public string Image { get; set; }
        public int ProductLineID { get; set; }
        public virtual ProductLine ProductLine { get; set; }
    }
}
