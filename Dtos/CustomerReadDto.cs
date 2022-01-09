using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Dtos
{
    public class CustomerReadDto
    {
       
        public string Surname { get; set; }
       
        public string Othername { get; set; }
       
        public string Firstname { get; set; }
        
        public string Title { get; set; }
        
        public string Status { get; set; }
        
        public string Gender { get; set; }
        
        public string PhoneNo { get; set; }
       
        public string Email { get; set; }
       
        public string Residence { get; set; }
       
        public string BVN { get; set; }

        public string Product { get; set; }
    }
}
