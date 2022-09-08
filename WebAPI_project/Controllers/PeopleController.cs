using Microsoft.AspNetCore.Mvc;
using WebAPI_project.Models;
using WebAPI_project.Services;

namespace WebAPI_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        IPersonService Pservice;

        public PeopleController(IPersonService pservice)
        {
            Pservice = pservice;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return this.Pservice.GetPeople();

        }
    }
}
