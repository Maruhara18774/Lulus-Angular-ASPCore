using Lulus.BAL.Catalog.Products.DTOs.Public;
using Lulus.BAL.Catalog.Products.Interfaces;
using Lulus.ViewModels.Products;
using Lulus.ViewModels.Products.Public;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int page, string keyword, string orderBy)
        {
            var result = await _productService.GetAll(page, keyword, orderBy);
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
        [HttpPost]
        public async Task<IActionResult> GetByCateID(GetProductPagingRequest request)
        {
            var result = await _productService.GetAllByCateID(request);
            foreach (var product in result)
            {
                foreach (var line in product.ListProductLines)
                {
                    line.Texture_Image_Url = "https://localhost:44354/"+line.Texture_Image_Url;
                    foreach(var image in line.ListImages)
                    {
                        image.Image_Url = "https://localhost:44354/" + image.Image_Url;
                    }
                }
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetBySubCateID(GetProductPagingRequest request)
        {
            var result = await _productService.GetAllBySubCateID(request);
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
        [HttpPost]
        public async Task<IActionResult> GetByDesignerID(GetProductPagingRequest request)
        {
            var result = await _productService.GetAllByDesignerID(request);
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
        [HttpPost]
        public async Task<IActionResult> GetByCateAndSubCateID(GetProductPagingRequest2 request)
        {
            var result = await _productService.GetAllByCateAndSubCateID(request);
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
        [HttpPost]
        public async Task<IActionResult> GetDetailByID(GetProductDetailRequest request)
        {
            var result = await _productService.GetDetailByID(request);

            foreach (var line in result.ListProductLines)
            {
                line.Texture_Image_Url = "https://localhost:44354/" + line.Texture_Image_Url;
                foreach (var image in line.ListImages)
                {
                    image.Image_Url = "https://localhost:44354/" + image.Image_Url;
                }
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetByCateIDFilter(FilterProductRequest filter)
        {
            var result = await _productService.GetFilterByCateID(filter);
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
        [HttpGet]
        public async Task<IActionResult> GetAllHot(int page)
        {
            var result = await _productService.GetAllHot(page);
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
        [HttpGet]
        public async Task<IActionResult> GetAllNew(int page)
        {
            var result = await _productService.GetAllNew(page);
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
