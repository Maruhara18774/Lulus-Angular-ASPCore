using Lulus.Data.EF;
using Lulus.ViewModels.FavoriteProduct;
using Lulus.ViewModels.Products;
using Lulus.ViewModels.Users;
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
        public Task<string> Add(AddFavoriteProductRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll(GetAllFavoriteProductRequest request)
        {
            //var userID = GetInfo(request.Token).ID;
            //var favors = await _context.Favo
            return null;
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
    }
}
