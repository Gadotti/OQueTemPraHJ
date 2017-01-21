using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OQTemPraHoje_v1.Controllers
{
    public class EventDetailsController : ApiController
    {
        // GET api/eventdetails
        public Data.Event Get()
        {
            return new Data.Event();
        }

        // GET api/eventdetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/eventdetails
        public void Post([FromBody]string value)
        {
        }

        // PUT api/eventdetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/eventdetails/5
        public void Delete(int id)
        {
        }
    }
}
