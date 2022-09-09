using Inficare.Bank.Service.Dtos;
using Inficare.Bank.Service.Interface.Authentication;
using Inficare.Bank.Service.Interface.Repository;
using Inficare.Bank.Service.Interface.Service;
using System;

namespace Inficare.Bank.Service.Implementation.Services
{
    public class LoginService:ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private readonly ITokenGenerator _tokenGenerator;

        public LoginService(ILoginRepository loginRepository, ITokenGenerator tokenGenerator)
        {
            _loginRepository = loginRepository;
            _tokenGenerator = tokenGenerator;
        }

        public BankEmployeeDto Login(string email, string password)
        {
            bool isSuccess = _loginRepository.Login(email, password);
            if (!isSuccess) throw new Exception("unauthorise credentials");
            var token = _tokenGenerator.GenerateToken(email);

            return new BankEmployeeDto
            {
                Email = email,
                Token = token
            };

        }
    }
}
