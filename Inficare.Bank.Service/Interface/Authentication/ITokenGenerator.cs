
namespace Inficare.Bank.Service.Interface.Authentication
{
    public interface ITokenGenerator
    {
        string GenerateToken(string email);
    }
}
