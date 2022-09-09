
using Inficare.Bank.Service.Dtos;
using Inficare.Bank.Service.Interface.Repository;
using Inficare.Bank.Service.Interface.Service;
using System.Collections.Generic;
using System.Linq;

namespace Inficare.Bank.Service.Implementation.Services
{
    public class BankService:IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public IList<BankDto> GetBankList()
        {
            var banks = _bankRepository.GetAllBanks();
            return banks.Select(x => new BankDto
            {
                Address=x.Address,
                Name=x.Name
            }).ToList();
        }
    }
}
