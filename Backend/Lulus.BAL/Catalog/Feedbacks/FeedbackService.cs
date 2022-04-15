using Lulus.BAL.Catalog.Feedbacks.Interfaces;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.ViewModels.Feedbacks;
using System;
using System.Collections.Generic;
using System.Linq;
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
                UserID = request.UserID,
                ProductID = request.ProductID,
                Created = DateTime.Now
            };
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
