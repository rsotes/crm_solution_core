using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs.Products;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService service;

        private readonly IUnitOfWork uow;

        public ProductsController(ProductService service, IUnitOfWork uow)
        {
            this.service = service;
            this.uow = uow;
        }

        [Route("")]
        [HttpGet]
        public async Task<ActionResult> GetProducts(int index, int max)
        {
            return await Task.FromResult(Ok(await service.FindProducts(index, max)));
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<ActionResult> Get(int id)
        {
            return await Task.FromResult(Ok(await service.FindProduct(id)));
            
        }

        [Route("")]
        [HttpPost]
        public async void Post(AddProductDto dto)
        {
            await service.AddAsync(dto);
            uow.Commit();
        }
    }
}
