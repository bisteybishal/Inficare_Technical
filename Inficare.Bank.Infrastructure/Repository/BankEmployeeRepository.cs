using Inficare.Bank.Infrastructure.Data;
using Inficare.Bank.Service.Interface.Repository;
using System.Linq;

namespace Inficare.Bank.Infrastructure.Repository
{
    public class BankEmployeeRepository : ILoginRepository
    {
        private AppDbContext _dbContext;

        public BankEmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Login(string email, string password)
        {

            var bankEmployee = _dbContext.BankEmployees.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            return bankEmployee != null;
        }
    }
}
