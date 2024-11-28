using DoAn3.Dto;
using DoAn3.Dto.Cart;
using DoAn3.Entities;

namespace DoAn3.Service.Interfaces
{
    public interface ICartService
    {
        void AddOrUpdateCartItem(AddToCartRequest cartItem);
        List<Cart> GetProductInCart(int userId);
        
    }
}
