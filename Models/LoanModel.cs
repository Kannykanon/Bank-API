using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    public class LoanModel
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Tenor { get; set; }
        [Required]
        public string InterestRate { get; set; }
        [Required]
        public string EffectiveDate { get; set; }
        [Required]
        public string FirstPayDate { get; set; }
        [Required]
        public string PrincipalFreq { get; set; }
        [Required]
        public string InterestFreq { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string AccountNumber { get; set; }
        [Required]
        public string PrincipalAmount { get; set; }
    }
}
