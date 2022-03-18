using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class OrderDetail:BaseAttribute
    {
        public int Quantity { get; set; }

        public double Total { get; set; }

        public int OrderID { get; set; }

        public int ProductLineID { get; set; }
        public bool IsFeedback { get; set; }

        public virtual Order Order { get; set; }

        public virtual ProductLine ProductLine { get; set; }
}
}
