using AutoMapper;
using Data.Dto;
using Models.Entities;
using Repository.Interface;
using Services.Interfaces;

namespace Services.Implementations
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IMapper _mapper;
        private readonly IBankAccountRepository bankAccountRepository;
        public BankAccountService(IMapper mapper, IBankAccountRepository bankAccountRepository)
        {
            _mapper = mapper;
           this.bankAccountRepository = bankAccountRepository;
        }
        public async Task AddBankAccount(BankAccountForCreateDto request)
        {
            BankAccount bankAccount = _mapper.Map<BankAccount>(request);
            await bankAccountRepository.AddBankAccount(bankAccount);    



        }
    }
}
