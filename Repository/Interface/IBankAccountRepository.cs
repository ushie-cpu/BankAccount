using Models.Entities;

namespace Repository.Interface
{
    public interface IBankAccountRepository
    {
        Task AddBankAccount(BankAccount bankAccount);
    }
}
