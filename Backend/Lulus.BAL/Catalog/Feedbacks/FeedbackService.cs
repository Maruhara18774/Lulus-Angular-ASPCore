using Lulus.BAL.Catalog.Feedbacks.Interfaces;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.ViewModels.Feedbacks;
using Lulus.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly LulusDBContext _context;

        public FeedbackService(LulusDBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateFeedback(CreateFeedbackRequest request)
        {
            var feedback = new Feedback()
            {
                StarCount = request.Star,
                Content = request.Content,
                UserID = GetInfo(request.Token).ID,
                ProductID = request.ProductID,
                Created = DateTime.Now
            };
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return true;
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
