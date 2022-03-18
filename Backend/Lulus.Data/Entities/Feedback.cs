using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Feedback:BaseAttribute
    {
        public int StarCount { get; set; }
        public bool IsAnonymous { get; set; }
        public string Content { get; set; }
        public Guid UserID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
