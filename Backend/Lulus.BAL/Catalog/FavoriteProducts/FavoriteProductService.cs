using Lulus.Data.EF;
using Lulus.ViewModels.FavoriteProduct;
using Lulus.ViewModels.ProductImages;
using Lulus.ViewModels.ProductLines;
using Lulus.ViewModels.Products;
using Lulus.ViewModels.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.FavoriteProducts
{
    public class FavoriteProductService : IFavoriteProductService
    {
        private readonly LulusDBContext _context;

        public FavoriteProductService(LulusDBContext context)
        {
            _context = context;
        }
        public async Task<string> Add(AddFavoriteProductRequest request)
        {
            var userID = GetInfo(request.Token).ID;
            var checkExist = await _context.FavoriteProducts.Where(x => x.UserID == userID && x.ProductID == request.ProductID).FirstOrDefaultAsync();
            if (checkExist != null) return "This product already exists in your favorites.";
            _context.FavoriteProducts.Add(new Data.Entities.FavoriteProduct()
            {
                UserID = userID,
                ProductID = request.ProductID
            });
            await _context.SaveChangesAsync();
            return "Success";
        }
        public async Task<bool> Remove(AddFavoriteProductRequest request)
        {
            var userID = GetInfo(request.Token).ID;
            var checkExist = await _context.FavoriteProducts.Where(x => x.UserID == userID && x.ProductID == request.ProductID).FirstOrDefaultAsync();
            if (checkExist == null) return false;
            _context.FavoriteProducts.Remove(checkExist);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<ProductViewModel>> GetAll(GetAllFavoriteProductRequest request)
        {
            var userID = GetInfo(request.Token).ID;
            var query = from p in _context.FavoriteProducts where p.UserID == userID select p;
            int totalRow = await query.CountAsync();

            var favorLs = await query.Skip((request.Page - 1) * 10).Take(10).ToListAsync();
            var data = new List<ProductViewModel>();
            foreach(var item in favorLs)
            {
                var prod = await _context.Products.Where(x => x.ID == item.ProductID).FirstOrDefaultAsync();
                data.Add(new ProductViewModel()
                {
                    ID = prod.ID,
                    Name = prod.Name,
                    Price = prod.Price,
                    Description = prod.Description,
                    Category_ID = prod.CategoryID,
                    DesignerID = prod.DesignerID,
                    AverageStar = 4,
                    Status = prod.Status
                });
            }
            foreach (var item in data)
            {
                item.AverageStar = await GetAvgFeedbackStar(item.ID);
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
                    Product_ID = p.ProductID,
                    Quantity = p.Quantity
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
                }
            }
            return data;
        }
        public UserViewModel GetInfo(string token)
        {
            try
            {
                var stream = token;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(stream);
                var tokenS = jsonToken as JwtSecurityToken;

                return new UserViewModel()
                {
                    ID = new Guid(tokenS.Claims.First(claim => claim.Type == ClaimTypes.PrimarySid.ToString()).Value),
                    Email = tokenS.Claims.First(claim => claim.Type == ClaimTypes.Email.ToString()).Value,
                    Username = tokenS.Claims.First(claim => claim.Type == ClaimTypes.Name.ToString()).Value,
                    Phone = tokenS.Claims.First(claim => claim.Type == ClaimTypes.MobilePhone.ToString()).Value
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<int> GetAvgFeedbackStar(int productID)
        {
            int sum = 0;
            var avgStar = await _context.Feedbacks.Where(x => x.ProductID == productID).ToListAsync();
            if (avgStar.Count == 0) return 5;
            foreach (var item in avgStar)
            {
                sum += item.StarCount;
            }
            return (int)sum / avgStar.Count;
        }

        
    }
}
