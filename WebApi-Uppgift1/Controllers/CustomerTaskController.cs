using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApi_Uppgift1.Models;
using WebApi_Uppgift1.Services;

namespace WebApi_Uppgift1.Controllers
{
    [Route("api/customerTasks")]
    [ApiController]
    public class CustomerTaskController : ControllerBase
    {
        private readonly SqlHandler<CustomerTask> customerTaskHandler = new SqlHandler<CustomerTask>();


        [HttpPost]

        public async Task<IActionResult> Create(CustomerTask customerTask)
        {
            try
            {
                await customerTaskHandler.CreateAsync("INSERT INTO CustomerTasks VALUES (@Headline, @Email, @CreatedDate, @TextMessage, @TaskStatus)", customerTask); //@Email, @TaskStatus, @TextMessage
                return new OkResult();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestResult();
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await customerTaskHandler.GetAsync("SELECT Headline, Email, CreatedDate, TextMessage, TaskStatus FROM CustomerTasks");
                return new OkObjectResult(result);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestResult();
        }
    }
}
