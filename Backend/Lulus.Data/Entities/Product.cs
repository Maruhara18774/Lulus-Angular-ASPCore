using Lulus.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Product: BaseAttribute
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int DesignerID { get; set; }

        public ProductStatus Status { get; set; }
        public LengthState? LengthState { get; set; }
        public SleeveLengthState? SleeveLengthState { get; set; }
        public virtual List<Feedback> Feedbacks { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<ProductLine> ProductLines { get; set; }
        public virtual List<Product_SubCategory> Product_SubCategories { get; set; }
        public virtual List<Product_Occation> Product_Occations { get; set; }
        public virtual Desinger Desinger { get; set; }
        public virtual List<FavoriteProduct> FavoriteProducts { get; set; }
        public virtual List<Sale> Sales { get; set; }
    }
}
