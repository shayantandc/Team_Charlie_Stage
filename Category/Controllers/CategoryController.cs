using Category.Commands;
using Category.Models;
using Category.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Category.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IMediator _mediator;

        public CategoryController (IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            return  Ok( _mediator.Send(new GetAllCategoryQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getCategoryById(int id)
        {
            return Ok(_mediator.Send(new GetCategoryByIdQuery() { CategoryId = id }));
        }
        [HttpPost("add")]
        public async Task<EcomCategory> AddCategory([FromBody] EcomCategory catname)
        {
            return await _mediator.Send(new AddCategoryCommand { CategoryName = catname});
        }
    }
}
