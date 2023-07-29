using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class BankAccount
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? AccountNumber { get; set; }
        [Required]
        public string? AccountHolderName { get; set; }
        [Required]
        public string? AccountType { get; set; }
        [Required]
        public decimal AccountBalance { get; set; } = 0;    
    }
}
