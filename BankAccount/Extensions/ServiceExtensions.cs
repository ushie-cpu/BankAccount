using Repository.Implementation;
using Repository.Interface;
using Services.Implementations;
using Services.Interfaces;

namespace BankAccount.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureBankService(this IServiceCollection services) =>
            services.AddScoped<IBankAccountService, BankAccountService>();

        public static void ConfigureBankRepository(this IServiceCollection services) =>
            services.AddScoped<IBankAccountRepository, BankAccountRepository>();
    }
}
