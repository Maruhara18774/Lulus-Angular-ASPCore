using Lulus.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Products.Public
{
    public class GetProductPagingRequest2 : PagingRequestBase
    {
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public GetProductPagingRequest2() { }
        public GetProductPagingRequest2(int cateid, int subid, int pIndex, int pSize) : base(pIndex, pSize)
        {
            this.CategoryID = cateid;
            this.SubCategoryID = subid;
        }
    }
}
