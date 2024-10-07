using Microsoft.AspNetCore.Mvc;
using PayMon.Models;
using PayMon.Repositories;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PayMon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public AuthController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] UserSignUpModel model)
        {
            var existingUser = await _userRepository.GetUserByUsername(model.Username);
            if (existingUser != null)
                return BadRequest("Username is already taken.");

            var user = new User
            {
                Username = model.Username,
                Email = model.Email,
                PasswordHash = HashPassword(model.Password)
            };

            await _userRepository.AddUser(user);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            var user = await _userRepository.GetUserByUsername(model.Username);
            if (user == null || !VerifyPassword(model.Password, user.PasswordHash))
                return Unauthorized("Invalid username or password.");

            // Ideally, generate a JWT token here to authenticate the user
            return Ok("Login successful");
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            var hash = HashPassword(password);
            return hash == storedHash;
        }
    }
}
