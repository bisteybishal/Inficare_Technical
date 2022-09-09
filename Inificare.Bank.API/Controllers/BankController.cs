using Inficare.Bank.Service.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inificare.Bank.API.Controllers
{

    public class BankController : CommonController
    {
        private readonly IBankService _bankService;
        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet("GetBankList")]
        public IActionResult GetAllBank()
        {
            var banks = _bankService.GetBankList();
            if (banks.Count > 0)
            {
                return Ok(banks);
            }
            return BadRequest("Something went wrong. Try again");
        }
    }
}
