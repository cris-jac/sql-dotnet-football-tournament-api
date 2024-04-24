using LaboratorioAws.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Security;
using Security.Data;
using Security.DTO;

namespace LaboratorioAws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthDbContext _authDbContext;
        private readonly TokenService _tokenService;
        public AuthController(
            AuthDbContext authDbContext, 
            TokenService tokenService
        )
        {
            _authDbContext = authDbContext;
            _tokenService = tokenService;
        }

        User user = new User
        {
            Id = 1,
            UserName = "Test",
            Email = "user@test.com",
            Name = "Test McTester"
        };

        [HttpGet]
        public async Task<ActionResult<string>> GetToken()
        {
            var response = new LoginResponseDto
            {
                Token = await _tokenService.GenerateToken(user),
                Username = user.UserName
            };

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            //var user = await _authDbContext.Users
        }
    }
}
