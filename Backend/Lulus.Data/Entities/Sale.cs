using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Sale:BaseAttribute
    {
        public int ProductID { get; set; }
        public double SalePrice { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int RemainQuantity { get; set; }
        public int Limit { get; set; }
        public virtual Product Product { get; set; }
    }
}
