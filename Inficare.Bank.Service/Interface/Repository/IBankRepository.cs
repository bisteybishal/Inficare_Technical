
using System.Linq;

namespace Inficare.Bank.Service.Interface.Repository
{
    public interface IBankRepository
    {
        IQueryable<Domain.Models.Bank> GetAllBanks();
    }
}
