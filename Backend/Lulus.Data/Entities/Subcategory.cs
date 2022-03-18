using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Subcategory:BaseAttribute
    {
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public virtual List<Product_SubCategory> Product_SubCategories { get; set; }
        public virtual List<FavoriteSubcategory> FavoriteSubcategories { get; set; }
    }
}
