using BankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Repositories
{
   public interface ICustomerRepo
    {
        bool SaveChanges();
        void CreateCUstomer(CustomerModel cmd);
        IEnumerable<CustomerModel> GetAllCustomer();
    }
}
