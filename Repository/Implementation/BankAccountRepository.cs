using Data.Dto;
using Models.Entities;
using Repository.Interface;

namespace Repository.Implementation
{
    public class BankAccountRepository : IBankAccountRepository
    {
        public Task AddAsync(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<BankAccount>> GetAllAsync(SearchParameters search, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<BankAccount> GetAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Remove(BankAccount aboutUs)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(BankAccount aboutUs)
        {
            throw new NotImplementedException();
        }
    }
}
