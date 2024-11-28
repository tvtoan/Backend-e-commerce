using DoAn3.Dto.User;
using DoAn3.Dtos.UserRole;

namespace DoAn3.Service.Interfaces
{
    public interface IUserRoleService
    {
        UserRoleDto Create(UserRoleDto input);
        void DeleteUserFromRole(int idRole, int idUser);
        IEnumerable<UserDto> GetUserFromRole(int idRole);
    }
}
