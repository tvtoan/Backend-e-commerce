using DoAn3.Dto.Cart;
using DoAn3.Dto.Payment;
using DoAn3.Entities;

namespace DoAn3.Service.Interfaces
{
    public interface IPaymentService
    {
        IEnumerable<PaymentDto> GetAll();
        void Create(CreatePayment input);
        void Update(int id, UpdatePayment input);
        void Delete(int id);
        PaymentDto GetById(int id);

    }
}
