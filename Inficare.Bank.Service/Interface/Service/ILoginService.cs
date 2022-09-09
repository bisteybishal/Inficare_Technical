using Inficare.Bank.Service.Dtos;

namespace Inficare.Bank.Service.Interface.Service
{
    public interface ILoginService
    {
        BankEmployeeDto Login(string email, string password);
    }
}
