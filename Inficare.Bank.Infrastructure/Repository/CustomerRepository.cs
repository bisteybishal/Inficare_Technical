using Microsoft.EntityFrameworkCore;
using Inficare.Bank.Domain.Models;
using Inficare.Bank.Infrastructure.Data;
using Inficare.Bank.Service.Interface.Repository;
using System.Linq;

namespace Inficare.Bank.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private AppDbContext _dbContext;

        public CustomerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Customer> GetAllCustomers()
        {
         return _dbContext.Customers.Include(x=>x.Bank).AsQueryable();
        }
    }
}
