using BankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Repositories
{
   public interface ILoan
    {
        bool SaveChanges();
        void CreateLoan(LoanModel cmd);
        IEnumerable<LoanModel> GetAllLoan();
    }
}
