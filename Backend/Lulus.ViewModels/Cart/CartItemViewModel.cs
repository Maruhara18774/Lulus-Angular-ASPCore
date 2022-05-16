using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Cart
{
    public class CartItemViewModel
    {
        public int ID { get; set; }
        public int LineID { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
