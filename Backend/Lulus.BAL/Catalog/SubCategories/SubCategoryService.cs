using Lulus.BAL.Catalog.SubCategories.Interfaces;
using Lulus.Data.EF;
using Lulus.ViewModels.SubCategories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.SubCategories
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly LulusDBContext _context;
        public SubCategoryService(LulusDBContext context)
        {
            _context = context;
        }
        public async Task<List<SubCateViewModel>> GetAllSubCategories()
        {
            var query = from c in _context.Subcategories
                        select c;
            var data = await query.Select(c => new SubCateViewModel()
            {
                ID = c.ID,
                Name = c.Name
            }).ToListAsync();
            return data;
        }
    }
}
