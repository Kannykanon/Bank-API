using BankAPI.Models;
using BankAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Profiles
{
    public class LoanRepo : ILoan
    {
        private readonly BankDbContext _context;
        public LoanRepo(BankDbContext context)
        {
            _context = context;
        }


        public void CreateLoan(LoanModel cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Add(cmd);
        }

        public IEnumerable<LoanModel> GetAllLoan()
        {
            return _context.LoanTab.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
