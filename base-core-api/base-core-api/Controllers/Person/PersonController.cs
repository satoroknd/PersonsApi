using App.Common.Classes.DTO;
using App.Domain.Services.AuthService;
using App.Domain.Services.PersonService;
using Microsoft.AspNetCore.Mvc;

namespace base_core_api.Controllers.Person
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IAuthService _personService;

        public PersonController(IAuthService personService)
        {
            _personService = personService;
        }

        [HttpPost("add-person")]
        public IActionResult AddPerson(RegisterDTO registerDto)
        {
            return Ok(_personService.RegisterUser(registerDto));
        }
    }
}
