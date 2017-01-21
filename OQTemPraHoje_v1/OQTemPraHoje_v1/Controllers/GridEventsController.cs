using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OQTemPraHoje_v1.Controllers
{
    public class GridEventsController : ApiController
    {
        // GET api/gridevents
        public List<Data.Event> Get()
        {
            return Data.Event.GetEvents();
        }

        // GET api/gridevents/periodo/regiao/categoria
        // GET api/gridevents/5
        [Route("api/gridevents/{periodo}/{regiao}/{categoria}")]
        public List<Data.Event> Get(int periodo, int regiao, int categoria)
        {
            return Data.Event.GetEvents();
        }

        // POST api/gridevents
        public void Post([FromBody]string value)
        {
        }

        // PUT api/gridevents/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/gridevents/5
        public void Delete(int id)
        {
        }
    }
}
