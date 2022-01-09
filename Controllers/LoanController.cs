using AutoMapper;
using BankAPI.Dtos;
using BankAPI.Models;
using BankAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Controllers
{
    [Route("api/Loan")]
    [ApiController]
    public class LoanController : Controller
    {
        private ILoan _loan;
        private IMapper _mapper;

        public LoanController(ILoan loan, IMapper mapper)
        {
            _loan = loan;
            _mapper = mapper;
        }

        //Get api loans
        [HttpGet]
        public ActionResult<IEnumerable<LoanReadDto>> GetAllLoan()
        {
            var loanItems = _loan.GetAllLoan();
            return Ok(_mapper.Map<IEnumerable<LoanReadDto>>(loanItems));
        }

        //Post api/loans
        [HttpPost]
        public ActionResult<LoanReadDto> CreateLoan(LoanCreateDto loanCreateDto)
        {
            var loanModel = _mapper.Map<LoanModel>(loanCreateDto);
            _loan.CreateLoan(loanModel);
            _loan.SaveChanges();
            var loanReadDto = _mapper.Map<LoanCreateDto>(loanModel);
            return Ok(loanReadDto);

        }
    }
}
