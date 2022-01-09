using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerModel> CustomerTab { get; set; }
        public DbSet<LoanModel> LoanTab { get; set; }
    }
}
