using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Address: BaseAttribute
    {
        public string Fullname { get; set; }
        public Guid UserID { get; set; }
        public int ProvinceID { get; set; }
        public string Phone { get; set; }
        public virtual User User { get; set; }
        public virtual Province Province { get; set; }

    }
}
