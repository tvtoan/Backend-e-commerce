using DoAn3.Dto.Cart;
using DoAn3.Dto.Category;
using DoAn3.Dto.Product;

namespace DoAn3.Service.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        void Create(CreateCategory input);
        void Update(int id, UpdateCategory input);
        CategoryDto GetById(int id);
        void Delete(int id);
        List<ProductDto> GetProductByCategory(int id);
    }
}
