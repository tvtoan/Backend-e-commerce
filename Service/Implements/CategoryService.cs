using DoAn3.Dto.Cart;
using DoAn3.Dto.Category;
using DoAn3.Dto.Product;
using DoAn3.Entities;
using DoAn3.Service.Interfaces;
using DoAnDNT.DbContexts;

namespace DoAnDNT.Service.Implements
{
    public class CategoryService : ICategoryService
    {
        private readonly MyDbContext _context;
        public CategoryService(MyDbContext context)
        {
            _context = context;
        }
        public void Create(CreateCategory input)
        {
            if (_context.Categories.Any(e => e.Name == input.Name))
            {
                throw new Exception("Tên loại sản phẩm bị trùng");
            }

            _context.Categories.Add(new Category
            {
               Name = input.Name,
            });
            _context.SaveChanges();
        }

        public void Update(int id, UpdateCategory input)
        {
            var cate = _context.Categories.SingleOrDefault(s => s.IdCategory == id);
            if (cate == null)
            {
                throw new Exception("Không tìm thấy loại sản phẩm");
            }

            cate.Name = input.Name;
            


            _context.SaveChanges();

        }
        public CategoryDto GetById(int id)
        {
            var cate = _context.Categories
                .Select(p => new CategoryDto
                {
                    IdCategory = p.IdCategory,
                    Name = p.Name,
                    
                })
                .FirstOrDefault(d => d.IdCategory == id);
            if (cate == null)
            {
                throw new Exception("Không tìm thấy loại sản phẩm");
            }
            return cate;

        }
        public IEnumerable<CategoryDto> GetAll()
        {
            var cate = _context.Categories.Select(p => new CategoryDto
            {
                IdCategory = p.IdCategory,
                Name = p.Name,

            }).ToList();
            return cate;
        }

        public void Delete(int id)
        {
            var delete = _context.Categories.Find(id);
            if (delete == null)
            {
                throw new Exception("Không tìm thấy loại sản phẩm");
            }
            _context.Categories.Remove(delete);
            _context.SaveChanges();
        }
        public List<ProductDto> GetProductByCategory(int id)
        {
            var product = _context.Products.Where(p => p.IdCategory == id).Select(p => new ProductDto
            {
                IdCategory = p.IdCategory,
                Name = p.Name,
                Price = p.Price,
                IdProduct = p.IdProduct,
                Images = p.Images,
                Color = p.Color,
                Description = p.Description,
                Size = p.Size,
            }).ToList();
            return product;
        }
    }
}
