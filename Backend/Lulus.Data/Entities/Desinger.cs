using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Desinger:BaseAttribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<FavoriteDesigner> FavoriteDesigners { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
