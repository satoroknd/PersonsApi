using App.Common.Classes.DTO;
using App.Domain.Services.AuthService;
using Microsoft.AspNetCore.Mvc;

namespace base_core_api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO registerDto)
        {
            return Ok(_authService.RegisterUser(registerDto));
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            return Ok(_authService.LoginUser(dto));
        }
    }
}
