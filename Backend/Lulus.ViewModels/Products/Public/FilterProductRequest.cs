using Lulus.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Products.Public
{
    public class FilterProductRequest : PagingRequestBase
    {
        public int ID { get; set; }
        public FilterProductRequest() { }
        public FilterProductRequest(int id, int pIndex, int pSize) : base(pIndex, pSize)
        {
            this.ID = id;
        }
        public int Designer { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public int Size { get; set; }
    }
}
