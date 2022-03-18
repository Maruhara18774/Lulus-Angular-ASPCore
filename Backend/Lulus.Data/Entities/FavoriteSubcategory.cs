using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class FavoriteSubcategory:BaseAttribute
    {
        public Guid UserID { get; set; }
        public int SubcategoryID { get; set; }
        public virtual User User { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
