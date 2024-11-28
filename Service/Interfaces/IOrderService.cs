using DoAn3.Dto.Cart;
using DoAn3.Dto.Order;
using DoAn3.Dto.Role;
using DoAn3.Entities;

namespace DoAn3.Service.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderDto> GetAll();
        void Create(CreateOrder input);
        void Update(int id, UpdateOrder input);
        void Delete(int id);
        OrderDto GetById(int id);
        void AddCartItemToOrder(int orderId, int userId);
        List<OrderDetail> GetOrderDetails(int id);
    }
}
