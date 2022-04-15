
using Lulus.BAL.Catalog.Products.DTOs;
using Lulus.BAL.Catalog.Products.DTOs.Public;
using Lulus.BAL.Catalog.Products.Interfaces;
using Lulus.Data.EF;
using Lulus.ViewModels.Feedbacks;
using Lulus.ViewModels.ProductImages;
using Lulus.ViewModels.ProductLines;
using Lulus.ViewModels.Products;
using Lulus.ViewModels.Products.Public;
using Lulus.ViewModels.Sizes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly LulusDBContext _context;

        public ProductService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetAllByCateAndSubCateID(GetProductPagingRequest2 request)
        {
            var query = from p in _context.Products
                        join l in _context.Product_SubCategories on p.ID equals l.ProductID
                        where (l.SubcategoryID == request.SubCategoryID) && (p.CategoryID == request.CategoryID)
                        select p;

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(p => new ProductViewModel()
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Category_ID = p.CategoryID,
                    DesignerID = p.DesignerID,
                    Status = p.Status
                }).ToListAsync();
            foreach (var item in data)
            {
                var productLines = from pl in _context.ProductLines
                                   where pl.ProductID == item.ID
                                   select pl;
                item.ListProductLines = await productLines.Select(p => new ProductLineViewModel()
                {
                    ID = p.ID,
                    Texture_Name = p.Texture.Name,
                    Texture_Image_Url = p.Texture.Image,
                    CreatedDate = p.Created,
                    UpdatedDate = p.Updated,
                    Product_ID = p.ProductID
                }).ToListAsync();
                foreach (var line in item.ListProductLines)
                {
                    var productImages = from i in _context.ProductImages
                                        where i.ProductLineID == line.ID
                                        select i;
                    line.ListImages = await productImages.Select(i => new ProductImageViewModel()
                    {
                        ID = i.ID,
                        Image_Url = i.Image,
                        ProductLine_ID = i.ProductLineID
                    }).ToListAsync();
                    var productSizes = from s in _context.Sizes
                                       join q in _context.ProductLine_Sizes on s.ID equals q.SizeID
                                       where q.ProductLineID == line.ID
                                       select s;
                    line.ListSizes = await productSizes.Select(s => new SizeViewModel()
                    {
                        ID = s.ID,
                        Key = s.Key
                    }).ToListAsync();
                }
            }
            return data;
        }

        public async Task<List<ProductViewModel>> GetAllByCateID(GetProductPagingRequest request)
        {
            var query = from p in _context.Products
                        where p.CategoryID == request.ID
                        select p;
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(p => new ProductViewModel()
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Category_ID = p.CategoryID,
                    DesignerID = p.DesignerID,
                    Status = p.Status
                }).ToListAsync();
            foreach (var item in data)
            {
                var productLines = from pl in _context.ProductLines
                                   where pl.ID == item.ID
                                   select pl;
                item.ListProductLines = await productLines.Select(p => new ProductLineViewModel()
                {
                    ID = p.ID,
                    Texture_Name = p.Texture.Name,
                    Texture_Image_Url = p.Texture.Image,
                    CreatedDate = p.Created,
                    UpdatedDate = p.Updated,
                    Product_ID = p.ProductID
                }).ToListAsync();
                foreach (var line in item.ListProductLines)
                {
                    var productImages = from i in _context.ProductImages
                                        where i.ProductLineID == line.ID
                                        select i;
                    line.ListImages = await productImages.Select(i => new ProductImageViewModel()
                    {
                        ID = i.ID,
                        Image_Url = i.Image,
                        ProductLine_ID = i.ProductLineID
                    }).ToListAsync();
                    var productSizes = from s in _context.Sizes
                                       join q in _context.ProductLine_Sizes on s.ID equals q.SizeID
                                       where q.ProductLineID == line.ID
                                       select s;
                    line.ListSizes = await productSizes.Select(s => new SizeViewModel()
                    {
                        ID = s.ID,
                        Key = s.Key
                    }).ToListAsync();
                }
            }
            return data;
        }

        public async Task<List<ProductViewModel>> GetAllBySubCateID(DTOs.Public.GetProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join l in _context.Product_SubCategories on p.ID equals l.ProductID
                        where l.SubcategoryID == request.ID
                        select p;

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(p => new ProductViewModel()
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Category_ID = p.CategoryID,
                    DesignerID = p.DesignerID,
                    Status = p.Status
                }).ToListAsync();
            foreach (var item in data)
            {
                var productLines = from pl in _context.ProductLines
                                   where pl.ProductID == item.ID
                                   select pl;
                item.ListProductLines = await productLines.Select(p => new ProductLineViewModel()
                {
                    ID = p.ID,
                    Texture_Name = p.Texture.Name,
                    Texture_Image_Url = p.Texture.Image,
                    CreatedDate = p.Created,
                    UpdatedDate = p.Updated,
                    Product_ID = p.ProductID
                }).ToListAsync();
                foreach (var line in item.ListProductLines)
                {
                    var productImages = from i in _context.ProductImages
                                        where i.ProductLineID == line.ID
                                        select i;
                    line.ListImages = await productImages.Select(i => new ProductImageViewModel()
                    {
                        ID = i.ID,
                        Image_Url = i.Image,
                        ProductLine_ID = i.ProductLineID
                    }).ToListAsync();
                    var productSizes = from s in _context.Sizes
                                       join q in _context.ProductLine_Sizes on s.ID equals q.SizeID
                                       where q.ProductLineID == line.ID
                                       select s;
                    line.ListSizes = await productSizes.Select(s => new SizeViewModel()
                    {
                        ID = s.ID,
                        Key = s.Key
                    }).ToListAsync();
                }
            }
            return data;
        }

        public async Task<ProductViewModel> GetDetailByID(GetProductDetailRequest request)
        {
            var query = from p in _context.Products
                        where p.ID == request.ID
                        select p;
            if (query == null) return null;
            ProductViewModel result = await query.Select(p => new ProductViewModel()
            {
                ID = p.ID,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Category_ID = p.CategoryID,
                DesignerID = p.DesignerID,
                Status = p.Status
            }).SingleOrDefaultAsync();
            var productLines = from pl in _context.ProductLines
                               where pl.ProductID == result.ID
                               select pl;
            result.ListProductLines = await productLines.Select(p => new ProductLineViewModel()
            {
                ID = p.ID,
                Texture_Name = p.Texture.Name,
                Texture_Image_Url = p.Texture.Image,
                CreatedDate = p.Created,
                UpdatedDate = p.Updated,
                Product_ID = p.ProductID
            }).ToListAsync();
            foreach (var line in result.ListProductLines)
            {
                var productImages = from i in _context.ProductImages
                                    where i.ProductLineID == line.ID
                                    select i;
                line.ListImages = await productImages.Select(i => new ProductImageViewModel()
                {
                    ID = i.ID,
                    Image_Url = i.Image,
                    ProductLine_ID = i.ProductLineID
                }).ToListAsync();
                var productSizes = from s in _context.Sizes
                                   join q in _context.ProductLine_Sizes on s.ID equals q.SizeID
                                   where q.ProductLineID == line.ID
                                   select s;
                line.ListSizes = await productSizes.Select(s => new SizeViewModel()
                {
                    ID = s.ID,
                    Key = s.Key,
                }).ToListAsync();
                foreach (var size in line.ListSizes)
                {
                    var quantity = from q in _context.ProductLine_Sizes
                                   where q.ProductLineID == line.ID && q.SizeID == size.ID
                                   select q;
                    size.Quantity = quantity.Select(s => s.Quantity).FirstOrDefault();
                }
            }
            var feedbacks = from f in _context.Feedbacks
                            where f.ProductID == result.ID
                            select f;
            result.ListFeedbacks = await feedbacks.Select(f => new FeedbackViewModel()
            {
                ID = f.ID,
                Star = f.StarCount,
                Content = f.Content,
                UserID = f.UserID,
                CreatedDate = f.Created,
                ProductID = f.ProductID,
                IsAnonymous = f.IsAnonymous
            }).ToListAsync();
            return result;
        }
    }
}
