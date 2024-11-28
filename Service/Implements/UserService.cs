using DoAn3.Dto.Payment;
using DoAn3.Dto.Role;
using DoAn3.Dto.User;
using DoAn3.Entities;
using DoAn3.Service.Interfaces;
using DoAnDNT.DbContexts;
using System.Net;

namespace DoAnDNT.Service.Implements
{
    public class UserService : IUserService
    {

        private readonly MyDbContext _context;
        public UserService(MyDbContext context)
        {
            _context = context;
        }
        public void Create(CreateUser input)
        {
            if (_context.Users.Any(e => e.FullName == input.FullName))
            {
                throw new Exception("ten nguoi dung  bị trùng");
            }

            _context.Users.Add(new User
            {
                FullName = input.FullName,
                Email = input.Email,
                PhoneNumber = input.PhoneNumber,
                Address = input.Address,
                Password= input.Password,
               

            });
            _context.SaveChanges();
        }

        public void Update(int id, UpdateUser input)
        {
            var user = _context.Users.SingleOrDefault(s => s.IdUser == id);
            if (user == null)
            {
                throw new Exception("Khong tim thay nguoi dung");
            }

            user.FullName = input.FullName;
            user.Email = input.Email;
            user.PhoneNumber = input.PhoneNumber;
            user.Address = input.Address;
            user.Password = input.Password;

            _context.SaveChanges();

        }

        public IEnumerable<UserDto> GetAll()
        {
            var user = _context.Users.Select(p => new UserDto
            {
                IdUser = p.IdUser,
                FullName = p.FullName,
                Email = p.Email,
                PhoneNumber = p.PhoneNumber,
                Address = p.Address,
                Password = p.Password,
            }).ToList();
            return user;
        }
        public UserDto GetById(int id)
        {
            var order = _context.Users
                .Select(p => new UserDto
                {
                    IdUser = p.IdUser,
                    FullName = p.FullName,
                    Email = p.Email,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address,
                    Password = p.Password,
                })
                .FirstOrDefault(d => d.IdUser == id);
            if (order == null)
            {
                throw new Exception("Không tìm thấy thông tin user");
            }
            return order;

        }


        public void Delete(int id)
        {
            var delete = _context.Users.Find(id);
            if (delete == null)
            {
                throw new Exception("Khong tim thay nguoi dung");
            }
            _context.Users.Remove(delete);
            _context.SaveChanges();
        }
    }
}
