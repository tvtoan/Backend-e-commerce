using DoAn3.Dto.OrderDetail;
using DoAn3.Entities;
using DoAn3.Service.Interfaces;
using DoAnDNT.DbContexts;

namespace DoAn3.Service.Implements
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly MyDbContext _dbContext;

        public OrderDetailService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(CreateOrderDetail input)
        {


            _dbContext.OrderDetails.Add(new OrderDetail
            {
                IdOrder = input.IdOrder,
                IdProduct = input.IdProduct,
                TotalPrice = input.TotalPrice,
                Quantity = input.Quantity,
            });
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var Order = _dbContext.OrderDetails.FirstOrDefault(x => x.IdOrderDetail == id);
            if (Order == null)
            {
                throw new Exception("Không tìm thấy thông tin đơn hàng ");
               
            }
            _dbContext.OrderDetails.Remove(Order);
            
            _dbContext.SaveChanges();
        }

        public List<OrderDetailDto> GetAll()
        {
            var orderDetail = _dbContext.OrderDetails.Select(o => new OrderDetailDto
            {
                IdProduct = o.IdProduct,
                IdOrder = o.IdOrder,
                TotalPrice = o.TotalPrice,
                Quantity = o.Quantity,

            });
            return orderDetail.ToList();
        }
        public OrderDetailDto GetById(int id)
        {
            var Order = _dbContext.OrderDetails
                .Select(x => new OrderDetailDto
                {
                    IdProduct = x.IdProduct,
                    TotalPrice = x.TotalPrice,
                    Quantity = x.Quantity,
                })
                .FirstOrDefault(x => x.IdOrderDetail == id);
            if (Order == null)
            {
                throw new Exception("Không tìm thấy thông tin đơn hàng");
            }
            return Order;

        }

        public void Update(UpdateOrderDetail input)
        {
            var Order = _dbContext.OrderDetails.FirstOrDefault(x => x.IdOrderDetail == input.IdOrderDetail);
            if (Order == null)
            {
                throw new Exception("Không tìm thấy thông tin sản phẩm");
            }

            
            Order.IdProduct = input.IdProduct;
            Order.TotalPrice = input.TotalPrice;
            Order.Quantity = input.Quantity;

            _dbContext.SaveChanges();
        }
    }
}
