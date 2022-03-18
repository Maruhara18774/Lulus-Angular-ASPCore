using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Product_Occation
    {
        public int ID { get; set; }
        public int OccationID { get; set; }
        public int ProductID { get; set; }
        public virtual Occation Occation { get; set; }
        public virtual Product Product { get; set; }
    }
}
