using Inficare.Bank.Service.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inificare.Bank.API.Controllers
{
    public class CustomerController : CommonController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetCustomerList")]
        public IActionResult GetAllCustomer()
        {
           var customers= _customerService.GetCustomerList();
            if (customers.Count > 0)
            {
                return Ok(customers);
            }
            return BadRequest("Something went wrong. Try again");
        }
    }
}
