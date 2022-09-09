using Inficare.Bank.Domain.Models;
using System.Linq;

namespace Inficare.Bank.Service.Interface.Repository
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllCustomers(); 
    }
}
