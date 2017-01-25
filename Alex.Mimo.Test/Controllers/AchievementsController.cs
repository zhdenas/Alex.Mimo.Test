using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alex.Mimo.Test.Controllers
{
    [Route("api/[controller]")]
    public class AchievementsController : BaseController
    {
        // GET: api/Achievements
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Achievements/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Achievements
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Achievements/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Achievements/5
        public void Delete(int id)
        {
        }
    }
}
