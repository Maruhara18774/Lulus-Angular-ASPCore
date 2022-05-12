using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Common
{
    public class SingleEnumViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SingleEnumViewModel() { }
        public SingleEnumViewModel(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
