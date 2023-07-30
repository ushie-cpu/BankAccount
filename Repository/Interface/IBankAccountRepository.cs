using Data.Dto;
using Models.Entities;

namespace Repository.Interface
{
    public interface IBankAccountRepository
    {
        Task AddAsync(BankAccount bankAccount);
        void Update(BankAccount aboutUs);
        void Remove(BankAccount aboutUs);
        Task<BankAccount> GetAsync(int id, bool trackChanges);
        Task<bool> Exists(string accountNumber);
        Task<PagedList<BankAccount>> GetAllAsync(SearchParameters search, bool trackChanges);
        Task SaveAsync();
    }
}
