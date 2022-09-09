using Inficare.Bank.Service.Dtos;
using Inficare.Bank.Service.Interface.Repository;
using Inficare.Bank.Service.Interface.Service;
using System.Collections.Generic;
using System.Linq;

namespace Inficare.Bank.Service.Implementation.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IList<CustomerDto> GetCustomerList()
        {
            var customers = _customerRepository.GetAllCustomers();
            return customers.Select(x => new CustomerDto
            {
                Id = x.Id,
                Name = x.Name,
                Bank=x.Bank
            }).ToList();
        }
    }
}
