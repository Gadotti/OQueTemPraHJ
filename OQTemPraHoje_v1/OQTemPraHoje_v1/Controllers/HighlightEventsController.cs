using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OQTemPraHoje_v1.Controllers
{
    public class HighlightEventsController : ApiController
    {
        // GET api/highlightevents
        public List<Data.Event> Get()
        {
            return Data.Event.GetHighlightEvents();
        }

        // GET api/highlightevents/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/highlightevents
        public void Post([FromBody]string value)
        {
        }

        // PUT api/highlightevents/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/highlightevents/5
        public void Delete(int id)
        {
        }
    }
}
