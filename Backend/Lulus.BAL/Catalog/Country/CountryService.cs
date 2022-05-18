using Lulus.Data.EF;
using Lulus.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Country
{
    public class CountryService: ICountryService
    {
        private readonly LulusDBContext _context;
        public CountryService(LulusDBContext context)
        {
            _context = context;
        }
        
        public async Task<List<SingleEnumViewModel>> GetAllCountry()
        {
            var query = from c in _context.Countries select c;
            return await query.Select(c => new SingleEnumViewModel()
            {
                ID = c.ID,
                Name = c.Name
            }).ToListAsync();
        }
        public async Task<List<SingleEnumViewModel>> GetAllCity(int id)
        {
            var query = from c in _context.Cities where c.CountryID == id select c;
            return await query.Select(c => new SingleEnumViewModel()
            {
                ID = c.ID,
                Name = c.Name
            }).ToListAsync();
        }

        public async Task<List<SingleEnumViewModel>> GetAllProvince(int id)
        {
            var query = from c in _context.Provinces where c.CityID == id select c;
            return await query.Select(c => new SingleEnumViewModel()
            {
                ID = c.ID,
                Name = c.Name
            }).ToListAsync();
        }
    }
}
