using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class ProductLine:BaseAttribute
    {
        public int TextureID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<ProductImage> ProductImages { get; set; }
        public virtual Product Product { get; set; }
        public virtual Texture Texture { get; set; }
    }
}
