using Lulus.Data.EF;
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

        public async Task<List<DesignerViewModel>> GetAllDesigner()
        {
            var designers = from d in _context.Desingers select d;
            return await designers.Select(d => new DesignerViewModel()
            {
                ID = d.ID,
                Name = d.Name
            }).ToListAsync();
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
    }
}
