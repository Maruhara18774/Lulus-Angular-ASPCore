using Lulus.ViewModels.Designer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Designers
{
    public interface IDesginerService
    {
        public Task<List<DesignerViewModel>> GetAllDesigner();
        public Task<DesignerViewModel> GetDesigner(int id);
    }
}
