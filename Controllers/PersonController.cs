using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using persons_api.Models;

namespace persons_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            return _personService.GetAll();
        }

        [HttpGet("id:int")]
        public Person GetPerson(int id)
        {
            return _personService.Get(id);
        }

        [HttpPost]
        public Person Create([FromBody] Person person)
        {
            return _personService.Insert(person);
        }
    }
}