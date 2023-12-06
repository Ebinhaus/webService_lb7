using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

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
        public string Get()
        {
            var filesPath = Directory.GetCurrentDirectory() + "/json/item.json"; //utf-8
            //var data = System.IO.File.OpenRead(filesPath);
            var text = System.IO.File.ReadAllText(filesPath);
            return text;
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
