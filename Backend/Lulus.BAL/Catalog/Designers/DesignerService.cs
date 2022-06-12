using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.ViewModels.Designer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Designers
{
    public class DesignerService: IDesginerService
    {
        private readonly LulusDBContext _context;
        public DesignerService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<List<DesignerViewModel>> GetDesignerByCate(int cateID)
        {
            var designers = await (from d in _context.Desingers select d).ToListAsync();
            var products = await (from p in _context.Products where p.CategoryID == cateID select p).ToListAsync();
            var result = new List<Desinger>();
            foreach(var item in products)
            {
                var designer = designers.Where(x => x.ID == item.DesignerID).FirstOrDefault();
                if(designer != null)
                {
                    result.Add(designer);
                    designers.Remove(designer);
                }
            }
            return result.Select(d => new DesignerViewModel()
            {
                ID = d.ID,
                Name = d.Name
            }).ToList();
        }

        public async Task<DesignerViewModel> GetDesigner(int id)
        {
            return await _context.Desingers.Where(x => x.ID == id).Select(x => new DesignerViewModel()
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description
            }).FirstOrDefaultAsync();
        }

        public async Task<List<DesignerViewModel>> GetAllDesigner()
        {
            var designers = await (from d in _context.Desingers select d).ToListAsync();
            return designers.Select(d => new DesignerViewModel()
            {
                ID = d.ID,
                Name = d.Name
            }).ToList();
        }
    }
}
