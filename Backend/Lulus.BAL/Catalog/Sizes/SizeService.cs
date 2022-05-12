using Lulus.Data.EF;
using Lulus.ViewModels.Sizes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Sizes
{
    public class SizeService: ISizeService
    {
        private readonly LulusDBContext _context;

        public SizeService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<List<SizeViewModel>> GetAll()
        {
            var sizes = from d in _context.Sizes select d;
            return await sizes.Select(s => new SizeViewModel()
            {
                ID = s.ID,
                Key = s.Key
            }).ToListAsync();
        }
    }
}
