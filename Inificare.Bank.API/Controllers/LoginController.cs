using Inficare.Bank.Service.Dtos;
using Inficare.Bank.Service.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inificare.Bank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Login(LoginRequestDto request)
        {
           var bankEmployeeDto = _loginService.Login(request.Email, request.Password);
            if (bankEmployeeDto == null)
            {
               return BadRequest("Invalid Login");
            }
            return Ok(bankEmployeeDto);
        }
    }
}
