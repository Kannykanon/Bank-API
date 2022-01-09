using AutoMapper;
using BankAPI.Dtos;
using BankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Profiles
{
    public class LoanProfile : Profile
    {
        public LoanProfile()
        {
            CreateMap<LoanModel, LoanReadDto>();
            CreateMap<LoanCreateDto, LoanModel>();
        }
    }
}
