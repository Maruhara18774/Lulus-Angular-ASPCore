using Lulus.BAL.Catalog.FavoriteProducts;
using Lulus.ViewModels.FavoriteProduct;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FavoriteProductController : Controller
    {
        private readonly IFavoriteProductService _favoriteProductService;
        public FavoriteProductController(IFavoriteProductService favoriteProductService)
        {
            _favoriteProductService = favoriteProductService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddFavoriteProductRequest request)
        {
            var result = await _favoriteProductService.Add(request);
            if(result != "Success")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(AddFavoriteProductRequest request)
        {
            var result = await _favoriteProductService.Remove(request);
            if (!result)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Get(GetAllFavoriteProductRequest request)
        {
            var result = await _favoriteProductService.GetAll(request);
            foreach (var product in result)
            {
                foreach (var line in product.ListProductLines)
                {
                    line.Texture_Image_Url = "https://localhost:44354/" + line.Texture_Image_Url;
                    foreach (var image in line.ListImages)
                    {
                        image.Image_Url = "https://localhost:44354/" + image.Image_Url;
                    }
                }
            }
            return Ok(result);
        }
    }
}
