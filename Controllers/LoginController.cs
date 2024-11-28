using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DoAnDNT.DbContexts;

namespace DoAn3.Controllers
{
    [EnableCors("AllowAllOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public LoginController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                // Kiểm tra xem người dùng có tồn tại trong cơ sở dữ liệu không
                var user = _dbContext.Users.FirstOrDefault(u => u.Email == request.Email && u.Password == request.Password);

                if (user != null)
                {
                    // Trả về thông tin người dùng nếu đăng nhập thành công
                    return Ok(new { user.IdUser, user.FullName, user.Email });
                }
                else
                {
                    // Trả về mã lỗi 401 nếu đăng nhập không thành công
                    return Unauthorized("Invalid email or password.");
                }
            }
            catch (Exception ex)
            {
                // Trả về mã lỗi 500 nếu có lỗi xảy ra
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {


            return Ok("Logout successful");
        }
    }
}
