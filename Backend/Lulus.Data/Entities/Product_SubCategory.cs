using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Product_SubCategory
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int SubcategoryID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
