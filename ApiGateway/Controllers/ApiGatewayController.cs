using ApiGateway.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ApiGateway.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiGatewayController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var url = "https://localhost:5001/api/Category/GetAllCategory";
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<CategoryDTO>(url);
            return Ok(content);

        }
        
    }
}
