using Lulus.ViewModels.Sizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Sizes
{
    public interface ISizeService
    {
        public Task<List<SizeViewModel>> GetAll();
    }
}
