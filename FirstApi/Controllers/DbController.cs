using FirstApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using OOPS;
namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        FirstApiContext context = null;
        public DbController(FirstApiContext ctx)
        {

            context = ctx;
        }

        [HttpPost("/insert")]
        public IActionResult InsertEmp([FromBody] Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return Created("/insert", emp);


        }
        [HttpGet("/all")]
        public IActionResult GetEmp()
        {
            return Ok(context.Employees.ToList());
        }
    }
}