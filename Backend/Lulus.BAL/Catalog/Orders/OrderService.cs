using Lulus.Data.EF;
using Lulus.ViewModels.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Orders
{
    public class OrderService: IOrderService
    {
        private readonly LulusDBContext _context;
        public OrderService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<OrderViewModel> Get(int id)
        {
            var order = await _context.Orders.Where(x => x.ID == id).Select(x => new OrderViewModel() 
            {
                ID = x.ID,
                Status = x.Status.ToString(),
                Total = x.Total,
                DatePurchase = x.Updated

            }).FirstOrDefaultAsync();
            order.Items = new List<OrderDetailViewModel>();
            var queryDetails = from d in _context.OrderDetails where d.OrderID == order.ID select d;
            var details = await queryDetails.ToListAsync();
            foreach (var detail in details)
            {
                var line = await _context.ProductLines.Where(x => x.ID == detail.ProductLineID).FirstOrDefaultAsync();
                var product = await _context.Products.Where(x => x.ID == line.ProductID).FirstOrDefaultAsync();
                order.Items.Add(new OrderDetailViewModel()
                {
                    ID = detail.ID,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = detail.Quantity,
                    Total = detail.Total,
                    IsFeedback = detail.IsFeedback
                });
            }
            return order;
        }

        public async Task<List<OrderViewModel>> GetAll(string token)
        {
            var userID = GetUserID(token);
            var query = from o in _context.Orders where o.UserID == userID select o;
            var orders = await query.Select(x => new OrderViewModel()
            {
                ID = x.ID,
                Status = x.Status.ToString(),
                Total = x.Total,
                DatePurchase = x.Updated
            }).ToListAsync();
            foreach(var item in orders)
            {
                var queryDetails = from d in _context.OrderDetails where d.OrderID == item.ID select d;
                var details = await queryDetails.ToListAsync();
                item.Items = new List<OrderDetailViewModel>();
                foreach(var detail in details)
                {
                    var line = await _context.ProductLines.Where(x => x.ID == detail.ProductLineID).FirstOrDefaultAsync();
                    var product = await _context.Products.Where(x => x.ID == line.ProductID).FirstOrDefaultAsync();
                    item.Items.Add(new OrderDetailViewModel()
                    {
                        ID = detail.ID,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = detail.Quantity,
                        Total = detail.Total,
                        IsFeedback = detail.IsFeedback
                    });
                }
            }
            return orders;
        }
        Guid GetUserID(string token)
        {
            var stream = token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = jsonToken as JwtSecurityToken;

            return new Guid(tokenS.Claims.First(claim => claim.Type == ClaimTypes.PrimarySid.ToString()).Value);
        }
    }
}
