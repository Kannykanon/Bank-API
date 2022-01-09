using BankAPI.Models;
using BankAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Profiles
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly BankDbContext _context;
        public CustomerRepo(BankDbContext context)
        {
            _context = context;
        }

        public void CreateCUstomer(CustomerModel cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Add(cmd);
        }

        public IEnumerable<CustomerModel> GetAllCustomer()
        {
            return _context.CustomerTab.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
