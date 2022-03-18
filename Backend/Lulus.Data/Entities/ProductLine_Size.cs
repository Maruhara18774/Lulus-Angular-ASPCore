using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lulus.Data.Entities;

namespace Lulus.Data.Entities
{
    public class ProductLine_Size
    {
        public int ID { get; set; }
        public int ProductLineID { get; set; }
        public int SizeID { get; set; }
        public int Quantity { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        public virtual Size Size { get; set; }

    }
}
