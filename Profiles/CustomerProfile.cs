using AutoMapper;
using BankAPI.Dtos;
using BankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, CustomerReadDto>();
            CreateMap<CustomerCreateDto, CustomerModel>();
        }
    }
}
