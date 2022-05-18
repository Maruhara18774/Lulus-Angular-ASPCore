using Lulus.BAL.Catalog.Cart;
using Lulus.ViewModels.Cart;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpPost]
        public async Task<IActionResult> Get(string token)
        {
            var result = await _cartService.Get(token);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Add2CartRequest request)
        {
            var result = await _cartService.Add(request);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Add2CartRequest request)
        {
            var result = await _cartService.Update(request);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _cartService.Delete(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Clear(string token)
        {
            var result = await _cartService.Clear(token);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutRequest request)
        {
            var result = await _cartService.Checkout(request);
            if(result == "")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
