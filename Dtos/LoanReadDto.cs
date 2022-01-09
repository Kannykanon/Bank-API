using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Dtos
{
    public class LoanReadDto
    {
        
        public string CustomerName { get; set; }
       
        public string Tenor { get; set; }
        
        public string InterestRate { get; set; }
        
        public string EffectiveDate { get; set; }
     
        public string FirstPayDate { get; set; }
        
        public string PrincipalFreq { get; set; }
       
        public string InterestFreq { get; set; }
       
        public string ProductCode { get; set; }
        
        public string AccountNumber { get; set; }
       
        public string PrincipalAmount { get; set; }
    }
}
