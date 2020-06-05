using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService customerService;

        private readonly IUnitOfWork uow;

        public CustomerController(CustomerService service, IUnitOfWork uow)
        {
            customerService = service;
            this.uow = uow;
        }

        [Route("")]
        [HttpPost]
        public  Task PostCustomer(AddCustomerRequestDto dto)
        {
            var res = Task.Run(() =>
            {
                customerService.Add(dto);
                uow.Commit();
            });
            
            return res;
        }

        [Route("")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerResponseDto>>> FindAll()
        {
            return Ok(await customerService.FindAll());
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<ActionResult<CustomerResponseDto>> GetCustomer(int id)
        {
            return await Task.FromResult(await customerService.Find(id));
        }

        [Route("{name:alpha}")]
        [HttpGet]
        public async Task<ActionResult<CustomerResponseDto>> FindByName(string name)
        {
            return await customerService.FindByName(name);
        }
    }
}
