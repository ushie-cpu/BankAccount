using Data.Dto;
using Models.Response;

namespace Services.Interfaces
{
    public interface IBankAccountService
    {
        Task<ApiBaseResponse> AddAsync(BankAccountForCreateDto request);
        Task<ApiBaseResponse> DeleteAsync(int id);
        Task<ApiBaseResponse> GetAsync(int id);
        Task<ApiBaseResponse> GetAllAsync(SearchParameters search);
        Task<ApiBaseResponse> UpdateAsync(int id, BankAccountForUpdate request);
    }
}
