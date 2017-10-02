using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace door_rest_srv.Controllers
{
    public class DoorController : ApiController
    {
        // GET: api/Door
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Door/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Door
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Door/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Door/5
        public void Delete(int id)
        {
        }
    }
}
