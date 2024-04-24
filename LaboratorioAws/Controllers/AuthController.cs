using LaboratorioAws.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Security;
using Security.Data;
using Security.DTO;

namespace LaboratorioAws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly TokenService _tokenService;
        public AuthController(
            UserRepository userRepository,
            TokenService tokenService
        )
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        User user = new User
        {
            Id = 1,
            UserName = "Test",
            Email = "user@test.com"
            //Name = "Test McTester"
        };

        [HttpGet]
        public async Task<ActionResult<string>> GetToken()
        {
            var response = new LoginResponseDto
            {
                Token = await _tokenService.GenerateToken(user),
                Email = user.Email
            };

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            var user = await _userRepository.GetUserByEmail(registerDto.Email);

            if (user != null) return BadRequest("User with this email already exists!");

            var newUser = RegisterService.RegisterUser(
                registerDto.Email, 
                registerDto.Username, 
                registerDto.Password
            );

            if (newUser == null) return BadRequest("Error while registering the user");

            await _userRepository.AddUser(newUser);
            await _userRepository.SaveChangesAsync();

            return Ok("User was registered successfully!");
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDto loginDto)
        {
            var user = await _userRepository.GetUserByUsername(loginDto.Username);

            if (user == null) return BadRequest("Username does not exist!");

            if (!LoginService.LoginUser(user, loginDto.Password))
            {
                return Unauthorized("Invalid password");
            }

            var response = new LoginResponseDto
            {
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };

            return Ok(response);
        }
    }
}
