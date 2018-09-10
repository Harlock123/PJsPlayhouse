using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobileServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        // GET: api/Auths
        [HttpGet]
        public IEnumerable<Auth> Get()
        {
            return new Auth[] { new Auth(),new Auth(),new Auth(),new Auth() };
        }

        // GET: api/Auths/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Auths
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Auths/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
