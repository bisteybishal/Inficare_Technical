
using Inficare.Bank.Service.Dtos;

namespace Inficare.Bank.Service.Interface.Repository
{
    public interface ILoginRepository
    {
        bool Login(string email, string password);
    }
}
