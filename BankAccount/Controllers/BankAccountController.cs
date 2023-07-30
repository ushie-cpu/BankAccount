using BankAccount.Controllers.Extensions;
using Data.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BankAccount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ApiControllerBase
    {
        private readonly IBankAccountService service;
        public BankAccountController(IBankAccountService service) =>
            this.service = service;

        ///<summary>End point to get a list of Bank Account</summary>
        ///<param name="search"></param>
        ///<returns>Paginated List of Bank Accountst</returns>
        ///<response code="200">OK</response>
        ///<response code="401">Unauthorized</response>
        ///<response code="403">Forbidden</response>
        ///<response code="500">Server error</response>
        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllBankAccounts([FromQuery] SearchParameters search)
        {
            var result = await service.GetAllAsync(search);
            if(!result.Success)
                ProcessError(result);

            return Ok(result.GetResult<PaginatedListDto<BankAccountForReturnDto>>());
        }

        ///<summary>End-point to create a new Bank Account</summary>
        ///<param name="request"></param>
        ///<returns>True or False</returns>
        ///<response code="201">Created</response>
        ///<response code="401">Unauthorized</response>
        ///<response code="403">Forbidden</response>
        ///<response code="500">Server error</response>
        [HttpPost]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddBankAccount(BankAccountForCreateDto request)
        {
            var result = await service.AddAsync(request);
            if (!result.Success)
                ProcessError(result);

            return Ok(result.GetResult<bool>());
        }

        ///<summary>End-point to create a new company</summary>
        ///<param name="id"></param>
        ///<returns>Created company object</returns>
        ///<response code="200">Created</response>
        ///<response code="401">Unauthorized</response>
        ///<response code="403">Forbidden</response>
        ///<response code="404">Not Found</response>
        ///<response code="500">Server error</response>
        [HttpGet("{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBankAccountById(int id)
        {
            var result = await service.GetAsync(id);
            if (!result.Success)
                ProcessError(result);

            return Ok(result.GetResult<BankAccountForReturnDto>());
        }

        ///<summary>End-point to update Bank Account</summary>
        ///<param name="id"></param>
        ///<param name="request"></param>
        ///<returns>Created company object</returns>
        ///<response code="200">OK</response>
        ///<response code="401">Unauthorized</response>
        ///<response code="403">Forbidden</response>
        ///<response code="404">Not Found</response>
        ///<response code="500">Server error</response>
        [HttpPatch("{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateBankAccount(int id, BankAccountForUpdate request)
        {
            var result = await service.UpdateAsync(id, request);
            if (!result.Success)
                ProcessError(result);

            return Ok(result.GetResult<bool>());
        }

        ///<summary>End-point to create a new company</summary>
        ///<param name="id"></param>
        ///<returns>Created company object</returns>
        ///<response code="200">Created</response>
        ///<response code="401">Unauthorized</response>
        ///<response code="403">Forbidden</response>
        ///<response code="404">Not Found</response>
        ///<response code="500">Server error</response>
        [HttpDelete("{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteBankAccount(int id)
        {
            var result = await service.DeleteAsync(id);
            if (!result.Success)
                ProcessError(result);

            return Ok(result.GetResult<bool>());
        }
    }
}
