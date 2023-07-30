using AutoMapper;
using Data.Dto;
using Models.Entities;
using Models.Response;
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

        public async Task<ApiBaseResponse> AddAsync(BankAccountForCreateDto request)
        {

            BankAccount bankAccount = _mapper.Map<BankAccount>(request);
            await bankAccountRepository.AddAsync(bankAccount);

            return new ApiOkResponse<bool>(true);
        }

        public async Task<ApiBaseResponse> UpdateAsync(int id, BankAccountForUpdate request)
        {
            BankAccount bankAccount = await bankAccountRepository.GetAsync(id, true);
            if (bankAccount == null) return new NotFoundResponse($"No account record found with Id {id}.");
        
            _mapper.Map(request, bankAccount);

            bankAccountRepository.Update(bankAccount);
            await bankAccountRepository.SaveAsync();

            return new ApiOkResponse<bool>(true);
        }

        public async Task<ApiBaseResponse> GetAsync(int id)
        {
            BankAccount bankAccount = await bankAccountRepository.GetAsync(id, false);
            if(bankAccount == null) return new NotFoundResponse($"No account record found with Id {id}.");

            var bankAccountToReturn = _mapper.Map<BankAccountForReturnDto>(bankAccount);

            return new ApiOkResponse<BankAccountForReturnDto>(bankAccountToReturn);
        }

        public async Task<ApiBaseResponse> GetAllAsync(SearchParameters search)
        {
            var bankAccounts = await bankAccountRepository.GetAllAsync(search, false);
            var bankAccountToReturn = _mapper.Map<IEnumerable<BankAccountForReturnDto>>(bankAccounts);

            var pagedData = PaginatedListDto<BankAccountForReturnDto>.Paginate(bankAccountToReturn, bankAccounts.MetaData);
            return new ApiOkResponse<PaginatedListDto<BankAccountForReturnDto>>(pagedData);
        }

        public async Task<ApiBaseResponse> DeleteAsync(int id)
        {
            BankAccount bankAccount = await bankAccountRepository.GetAsync(id, true);
            if (bankAccount == null) return new NotFoundResponse($"No account record found with Id {id}.");

            bankAccountRepository.Remove(bankAccount);
            await bankAccountRepository.SaveAsync();

            return new ApiOkResponse<bool>(true);
        }
    }
}
