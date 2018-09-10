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
    public class CareGapsController : ControllerBase
    {
        // GET: api/CareGaps
        [HttpGet]
        public IEnumerable<CareGap> Get()
        {
            return new CareGap[] { new CareGap("TYPE1","A Long Description",DateTime.Now,Convert.ToDateTime(null),"Reason 1","Rational 1"),
                                   new CareGap("TYPE2","A Long Description",DateTime.Now,Convert.ToDateTime(null),"Reason 2","Rational 2"),
                                   new CareGap("TYPE3","A Long Description",DateTime.Now,Convert.ToDateTime(null),"Reason 3","Rational 3") };
        }

        // GET: api/CareGaps/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CareGaps
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/CareGaps/5
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
