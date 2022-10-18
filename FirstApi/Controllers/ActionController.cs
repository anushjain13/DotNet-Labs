using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        [HttpGet("/str/get")]
        public IActionResult GetStr()
        {
            return Ok(_actions);
        }

        //small database
        private static List<string> _actions = new List<string>();

        [HttpPost("/Str/insert")]
        public IActionResult InsertStr([FromBody] string Str)
        {
            if (Str == "none")
            {
                BadRequest("none is not allowed"); //status = 400
            }
            _actions.Add(Str);
            return Ok($"{Str} added succesfully!");
        }
        [HttpPut("/str/update/{oldStr}")]

        public IActionResult UpdateStr([FromRoute] string oldStr, [FromBody] string newStr)
        {
            //finding the string
            string? foundStr = _actions.Where((s)=> { return s == oldStr; }).ToList().FirstOrDefault();
            if (foundStr == null || foundStr == "")
            {
                return NotFound();  //404 error
            }

            //Update the string
            foundStr = newStr;

            return NoContent();
        }

        [HttpDelete("/str/delete/{strToRemove}")]
        public IActionResult RemoveStr(string strToRemove)
        {
            bool isSuccessful = _actions.Remove(strToRemove);
            if (isSuccessful == true)
            {
                return Ok($"Deletion successful for {strToRemove}");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
