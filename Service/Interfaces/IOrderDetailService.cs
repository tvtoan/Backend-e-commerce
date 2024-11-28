using DoAn3.Dto.OrderDetail;

namespace DoAn3.Service.Interfaces
{
    public interface IOrderDetailService
    {
        List<OrderDetailDto> GetAll();
        OrderDetailDto GetById(int id);
        void Create(CreateOrderDetail input);
        void Update(UpdateOrderDetail input);
        void Delete(int id);    
    }
}
