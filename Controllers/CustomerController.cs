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
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepo _repository;
        private IMapper _mapper;

        public CustomerController(ICustomerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get api customers
        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDto>> GetAllCustomers()
        {
            var customerItems = _repository.GetAllCustomer();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customerItems));
        }

        //Post api/commands
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<CustomerModel>(customerCreateDto);
            _repository.CreateCUstomer(customerModel);
            _repository.SaveChanges();
            var customerReadDto = _mapper.Map<CustomerCreateDto>(customerModel);
            return Ok(customerReadDto);

        }
    }
}
