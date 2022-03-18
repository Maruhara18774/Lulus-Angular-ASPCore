using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class FavoriteDesigner:BaseAttribute
    {
        public Guid UserID { get; set; }
        public int DesignerID { get; set; }
        public virtual User User { get; set; }
        public virtual Desinger Desinger { get; set; }
    }
}
