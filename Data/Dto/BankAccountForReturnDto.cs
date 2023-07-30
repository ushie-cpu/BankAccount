namespace Data.Dto
{
    public record BankAccountForReturnDto
    {
        public int Id { get; init; }
        public string? AccountNumber { get; init; }
        public string? AccountHolderName { get; init; }
        public string? AccountType { get; init; }
        public decimal AccountBalance { get; init; }
    }
}
