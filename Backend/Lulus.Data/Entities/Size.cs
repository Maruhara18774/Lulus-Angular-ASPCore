using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Size:BaseAttribute
    {
        public string Key { get; set; }

        public virtual List<ProductLine_Size> ProductLine_Sizes { get; set; }
    }
}
