using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        private readonly IUnitOfWork Uow;

        public OrderController(OrderService service, IUnitOfWork uow)
        {
            orderService = service;
            Uow = uow;
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<ActionResult> GetOrderr(int id)
        {
            return await Task.FromResult(Ok(await orderService.Find(id)));
        }

        [Route("")]
        public async Task<ActionResult> PostOrder(AddOrderRequest dto)
        {
            await orderService.Add(dto);
            Uow.Commit();
            return await Task.FromResult(Ok());
        }
    }
}
