using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class FavoriteProduct:BaseAttribute
    {
        public Guid UserID { get; set; }
        public int ProductID { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
