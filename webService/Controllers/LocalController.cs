using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalController : ControllerBase
    {
        private static List<String> list = new List<string>()
        {
            
        };

        // GET: api/<LocalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"asd"};
        }

        // GET api/<LocalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
