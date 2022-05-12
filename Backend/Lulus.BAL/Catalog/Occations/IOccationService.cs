using Lulus.ViewModels.Occations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Occations
{
    public interface IOccationService
    {
        public Task<List<OccationViewModel>> GetAll();
    }
}
