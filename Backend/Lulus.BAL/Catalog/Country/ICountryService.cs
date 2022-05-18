using Lulus.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Country
{
    public interface ICountryService
    {
        Task<List<SingleEnumViewModel>> GetAllCountry();
        Task<List<SingleEnumViewModel>> GetAllCity(int id);
        Task<List<SingleEnumViewModel>> GetAllProvince(int id);
    }
}
