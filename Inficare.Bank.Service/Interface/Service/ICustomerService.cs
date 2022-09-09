using Inficare.Bank.Service.Dtos;
using System.Collections.Generic;

namespace Inficare.Bank.Service.Interface.Service
{
    public interface ICustomerService
    {
        IList<CustomerDto> GetCustomerList();
    }
}
