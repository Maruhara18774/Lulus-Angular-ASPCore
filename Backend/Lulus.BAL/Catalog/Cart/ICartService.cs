using Lulus.ViewModels.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Cart
{
    public interface ICartService
    {
        Task<CartViewModel> Get(string token);
        Task<bool> Add(Add2CartRequest request);
        Task<bool> Update(Add2CartRequest request);
        Task<bool> Delete(int id);
    }
}
