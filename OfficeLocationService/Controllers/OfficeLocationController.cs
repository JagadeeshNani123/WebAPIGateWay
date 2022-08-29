using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfficeLocationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeLocationController : ControllerBase
    {
        // GET: api/<OfficeLocationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "location 1", "location 2" };
        }

        // GET api/<OfficeLocationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OfficeLocationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OfficeLocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OfficeLocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
