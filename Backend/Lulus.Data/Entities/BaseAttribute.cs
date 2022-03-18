using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class BaseAttribute
    {
        public int ID { get; set; }
        public bool Active { get; set; } = true;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid UserIDCreated { get; set; }
        public Guid UserIDUpdated { get; set; }
    }
}
