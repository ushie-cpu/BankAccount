using Models.Response;

namespace BankAccount.Controllers.Extensions
{
    public static class ApiBaseResponseExtensions
    {
        public static TResultType GetResult<TResultType>(this ApiBaseResponse apiBaseResponse) =>
            ((ApiOkResponse<TResultType>)apiBaseResponse).Result;
    }
}
