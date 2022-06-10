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
        Task<List<OrderViewModel>> GetAll(GetAllOrderRequest request);
        Task<OrderViewModel> Get(int id);
        Task<bool> Cancel(int id);
    }
}
