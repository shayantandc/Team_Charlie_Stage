using Products.Commands;
using Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Category.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediatr;



        public ProductsController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
        // GET: api/<LoginController>
        [HttpGet("{id}")]
        //[Route("getUsersById")]
        public async Task<EcomProducts> Get(int id)
        {
            return await _mediatr.Send(new GetProductsbyId()
            {
                Id = id
            });
        }

        //// GET api/<LoginController>/5
        [HttpGet]
        //[Route("getUsers")]
        public async Task<IEnumerable<EcomProducts>> getAllProducts()
        {
            return await _mediatr.Send(new GetAllProducts());
        }

        // POST api/<LoginController>
        [HttpPost]
        public async Task<EcomProducts> Post(int catid, string name, string type, decimal price, string desc)
        {
            return await _mediatr.Send(new AddProduct()
            {
                CatId = catid,
                Name = name,
                Type = type,
                Price = price,
                Desc = desc
            }
                );
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
