using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SensorUltrasonico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class Registro : ControllerBase
    {
        // GET: api/<Registro>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Registro>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Registro>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Registro>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Registro>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
