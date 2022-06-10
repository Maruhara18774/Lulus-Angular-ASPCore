using Lulus.BAL.Catalog.Orders;
using Lulus.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public async Task<IActionResult> GetList(GetAllOrderRequest request)
        {
            var result = await _orderService.GetAll(request);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _orderService.Get(id);
            return Ok(result);
        }
        [HttpGet("Cancel/{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            var result = await _orderService.Cancel(id);
            return Ok(result);
        }
    }
}
