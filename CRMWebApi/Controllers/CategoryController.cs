using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs.Products;
using Services.Exceptions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService categoryService;

        private readonly IUnitOfWork Uow;

        public CategoryController(CategoryService cService, IUnitOfWork uow)
        {
            categoryService = cService;
            Uow = uow;
        }

        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<CategoryResponseDto>> FindAll()
        {
            return await categoryService.FindAllASync();
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<CategoryResponseDto> GetCategory(int id)
        {
            return await categoryService.FindAsync(id);
        }

        [Route("")]
        [HttpPost]
        public void PostCategory(AddCategoryDto dto)
        {
            if (dto == null) throw new CategoryRequiredException("Category is required");
            categoryService.AddCategory(dto);
            Uow.Commit();
        }
    }
}
