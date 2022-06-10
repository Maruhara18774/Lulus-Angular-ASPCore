using Lulus.ViewModels.FavoriteProduct;
using Lulus.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.FavoriteProducts
{
    public interface IFavoriteProductService
    {
        Task<List<ProductViewModel>> GetAll(GetAllFavoriteProductRequest request);
        Task<string> Add(AddFavoriteProductRequest request);
        Task<bool> Remove(AddFavoriteProductRequest request);
    }
}
