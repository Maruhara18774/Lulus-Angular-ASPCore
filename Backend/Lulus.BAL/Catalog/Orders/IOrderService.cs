using Lulus.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Orders
{
    public interface IOrderService
    {
        Task<List<OrderViewModel>> GetAll(string token);
        Task<OrderViewModel> Get(int id);
    }
}
