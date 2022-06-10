using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.FavoriteProduct
{
    public class AddFavoriteProductRequest
    {
        public string Token { get; set; }
        public int ProductID { get; set; }
    }
}
