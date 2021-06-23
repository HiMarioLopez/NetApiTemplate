using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOnionApi.Application.Features.Employees.Queries.GetEmployees;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyOnionApi.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class EmployeesController : BaseApiController
    {
        /// <summary>
        /// GET: api/controller
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetEmployeesQuery filter, string version)
        {
            return Ok(await Mediator.Send(filter));
        }
    }
}