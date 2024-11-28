using DoAn3.Dto.Cart;
using DoAn3.Dto.Common;
using DoAn3.Dto.Product;

namespace DoAn3.Service.Interfaces
{
    public interface IProductService
    {
        void  Create(CreateProduct input);
        void Update(int id, UpdateProduct input);
        void Delete(int id);
        ProductDto GetById(int id);
        IEnumerable<ProductDto> GetAll();
    }
}
