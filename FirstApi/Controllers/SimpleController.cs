using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOPS;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleController : ControllerBase
    {
        [HttpGet("/Greet")]
        public string Greeting(string pName)
        {
            return $"Hello {pName}";
        }

        [HttpGet("/allnames")]
        public List<string> AllNames()
        {
            List<string> names = new List<string>() { "satish", "Anush", "Parth" };
            return names;


        }
        [HttpGet("/kpmg/employees")]
        public List<KpmgEmployee> GetAllEmployees()
        {
            List<KpmgEmployee> kpmgEmployees = new List<KpmgEmployee>();
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Anush", Designation = "Analyst" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1002, Name = "Satish", Designation = "Manager" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1003, Name = "Murali", Designation = "Doctor" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1004, Name = "Parth", Designation = "Comedian" });

            return kpmgEmployees;
        }
        [HttpGet("/employees/search/{pName}")] //https://localhost:7272/employees/search/satish
        public List<KpmgEmployee> SearchEmployee([FromRoute] string pName)
        {

            List<KpmgEmployee> allEmps = GetAllEmployees();
            return allEmps.Where((emp) => { return emp.Name == pName; })
                        .ToList();
        }

        [HttpGet("/employees/search/{pName}/{Designation}")]

        public List<KpmgEmployee> SearchEmployee([FromRoute] string pName, string Designation)
        {

            List<KpmgEmployee> allEmps = GetAllEmployees();
            return allEmps.Where((emp) => { return emp.Name.Contains("a") && emp.Designation == Designation; })
                        .ToList();
        }

        [HttpGet("/IAction")]
        public IActionResult GetUsingAction()
        {
            List<KpmgEmployee> kpmgEmployees = new List<KpmgEmployee>();
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1001, Name = "Anush", Designation = "Analyst" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1002, Name = "Satish", Designation = "Manager" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1003, Name = "Murali", Designation = "Doctor" });
            kpmgEmployees.Add(new KpmgEmployee() { EmpId = 1004, Name = "Parth", Designation = "Comedian" });

            return Ok(kpmgEmployees);
        }
    }
}