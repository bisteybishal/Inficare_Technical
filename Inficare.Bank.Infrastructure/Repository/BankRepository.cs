
using Inficare.Bank.Infrastructure.Data;
using Inficare.Bank.Service.Interface.Repository;
using System.Linq;

namespace Inficare.Bank.Infrastructure.Repository
{
    public class BankRepository : IBankRepository
    {
        private AppDbContext _dbContext;

        public BankRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Domain.Models.Bank> GetAllBanks()
        {
            return _dbContext.Banks;
        }
    }
}
