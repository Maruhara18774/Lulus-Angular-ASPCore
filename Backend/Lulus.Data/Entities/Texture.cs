using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Texture: BaseAttribute
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        public virtual List<ProductLine> ProductLines { get; set; }
    }
}
