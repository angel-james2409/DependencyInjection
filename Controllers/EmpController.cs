using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private static readonly string[] FirstName = new[]
        {
            "Ang","james","subha"
        };
        private static readonly string[] LastName = new[]
        {
            "james","asher","lakshmi"
        };
        private readonly ILogger<EmpController> _logger;
        private readonly IEmp _myEmp;
       

        public EmpController(ILogger<EmpController> logger, MyEmp emp)
        {
            _logger = logger;
            _myEmp = emp;
        }

        [HttpGet]
        public IEnumerable<EmpController> Get()
        {
            _myEmp.WriteMessage("inside the emp controller get first name");
            _myEmp.WriteMessage("inside the emp controller get last name");
            return Emp.Get();

        }

       


        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
