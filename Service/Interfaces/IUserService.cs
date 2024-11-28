using DoAn3.Dto.Payment;
using DoAn3.Dto.User;

namespace DoAn3.Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        void Create(CreateUser input);
        void Update(int id, UpdateUser input);
        void Delete(int id);
        UserDto GetById(int id);
    }
}
