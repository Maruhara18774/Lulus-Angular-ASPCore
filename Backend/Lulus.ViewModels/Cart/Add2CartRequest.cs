using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Cart
{
    public class Add2CartRequest
    {
        public string token { get; set; }
        public int LineID { get; set; }
        public int Quantity { get; set; }
    }
}
