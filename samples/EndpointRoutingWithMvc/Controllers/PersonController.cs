using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EndpointRoutingWithMvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<Person> GetAll() => null;

        //[HttpGet("{id}")]
        //public Person Get(int id) => null;

        //[HttpPut("{id}")]
        //public Person Update(int id, Person person) => null;

        //[HttpPost]
        //[Consumes("application/json")]
        //public Person CreateJson(PersonJson person) => null;


        //[HttpPost]
        //[Consumes("application/xml")]
        //public Person CreateJson(PersonXml person) => null;
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class PersonJson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class PersonXml
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
