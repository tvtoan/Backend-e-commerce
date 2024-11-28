using DoAn3.Dto.Payment;
using DoAn3.Dto.Role;
using DoAn3.Dto.User;

namespace DoAn3.Service.Interfaces
{
    public interface IRoleService
    {
        IEnumerable<RoleDto> GetAll();
        void Create(CreateRole input);
        void Update(int id, UpdateRole input);
        void Delete(int id);
        RoleDto GetById(int id);
    }
}
