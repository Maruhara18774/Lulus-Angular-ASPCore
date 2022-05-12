using Lulus.Data.EF;
using Lulus.ViewModels.Occations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Occations
{
    public class OccationService: IOccationService
    {
        private readonly LulusDBContext _context;
        public OccationService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<List<OccationViewModel>> GetAll()
        {
            var occations = from o in _context.Occations select o;
            return await occations.Select(d => new OccationViewModel()
            {
                ID = d.ID,
                Name = d.Name
            }).ToListAsync();
        }
    }
}
