using Event.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Event.Controllers
{
   [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET: api/test
       [Authorize]
        [HttpGet]
       // [Route("ping/secure")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Test1", "Test2" };

            Db db = new Db();
            db.Save();

            return new string[] { "Test1", "Test2" };
        }

        // GET api/test/5
       // [HttpGet("{id}")]
       // public string Get(int id)
       // {
       //     return "Id";
       // }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
