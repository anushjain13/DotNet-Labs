using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOPS;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KpmgController : ControllerBase
    {
        [HttpGet("/Kpmg/get")]
        public IActionResult GetStr()
        {
            return Ok(_actions);
        }

        //small database
        private static List<KpmgEmployee> _actions = new List<KpmgEmployee>();

        [HttpPost("/Kpmg/insert")]
        public IActionResult InsertStr([FromBody] KpmgEmployee Str)
        {
            if (Str == null)
            {
                BadRequest("none is not allowed"); //status = 400
            }
            _actions.Add(Str);
            return Created("/str/insert", $"{Str.Name} added succesfully!");
        }
        [HttpPut("/Kpmg/update/{empId}")]

        public IActionResult UpdateStr([FromRoute] int empId, [FromBody] KpmgEmployee newStr)
        {
            //finding the string
            KpmgEmployee? foundStr = _actions.Where((s) => { return s.EmpId == empId; }).ToList().FirstOrDefault();
            if (foundStr == null)
            {
                return NotFound();  //404 error
            }

            //Update the string
            foundStr.Name = newStr.Name;
            foundStr.EmpId = newStr.EmpId;
            return NoContent();
        }

        [HttpDelete("/Kpmg/delete/{empId}")]
        public IActionResult RemoveStr([FromRoute] int empId)
        {
            KpmgEmployee? foundEmp = _actions.Where((emp) => { return emp.EmpId == empId; }).FirstOrDefault();
            bool isSuccessful = _actions.Remove(foundEmp);
            if (isSuccessful == true)
            {
                return Ok($"Deletion successful for {empId}");
            }
            else
            {
                return NotFound();
            }
        }
    }
}

