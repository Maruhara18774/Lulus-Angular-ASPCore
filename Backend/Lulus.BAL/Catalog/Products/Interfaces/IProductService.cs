using Lulus.BAL.Catalog.Products.DTOs.Public;
using Lulus.ViewModels.Products;
using Lulus.ViewModels.Products.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Products.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllByCateID(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetAllBySubCateID(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetAllByCateAndSubCateID(GetProductPagingRequest2 request);
        Task<ProductViewModel> GetDetailByID(GetProductDetailRequest request);
        Task<List<ProductViewModel>> GetAll(int pageIndex);
        Task<List<ProductViewModel>> GetFilterByCateID(FilterProductRequest filter);
        Task<List<ProductViewModel>> GetAllHot(int pageIndex);

    }
}
