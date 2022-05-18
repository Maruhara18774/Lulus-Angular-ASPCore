using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Cart
{
    public class CheckoutRequest
    {
        public string Token { get; set; }
        public string Fullname { get; set; }
        public int ProvinceID { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
