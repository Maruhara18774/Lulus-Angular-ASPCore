using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Cart
{
    public class CartViewModel
    {
        public int ID { get; set; }
        public Guid UserID { get; set; }
        public double Total { get; set; }
        public int LineCount { get; set; }
        public List<CartItemViewModel> Items { get; set; }
    }
}
