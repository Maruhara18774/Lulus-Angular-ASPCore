using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Order
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
        public DateTime DatePurchase { get; set; }

        public virtual List<OrderDetailViewModel> Items { get; set; }
    }
}
