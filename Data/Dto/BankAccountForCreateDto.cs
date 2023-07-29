using System.ComponentModel.DataAnnotations;

namespace Data.Dto
{
    public record BankAccountForCreateDto
    {
        [Required]
        public string? AccountHolderName { get; init; }
        [Required]
        public string? AccountType { get; init; }
    }
}
