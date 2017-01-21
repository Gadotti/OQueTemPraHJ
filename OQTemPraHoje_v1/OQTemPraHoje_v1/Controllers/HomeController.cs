using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OQTemPraHoje_v1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }

        public PartialViewResult HighlightEvents()
        {
            var listEvent = new List<Data.Event>();           

            const string baseUri = "http://localhost:6268/api/HighlightEvents/";

            using (var httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(baseUri);
                listEvent = JsonConvert.DeserializeObjectAsync<List<Data.Event>>(response.Result).Result;
            }

            return PartialView(listEvent);
        }

        public PartialViewResult GridEvents(int periodo, int regiao, int categoria)
        {
            var listEvent = new List<Data.Event>();

            string baseUri = "http://localhost:6268/api/GridEvents/" + periodo + "/" + regiao + "/" + categoria;

            using (var httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(baseUri);
                listEvent = JsonConvert.DeserializeObjectAsync<List<Data.Event>>(response.Result).Result;
            }

            return PartialView(listEvent);
        }

        //public PartialViewResult GridEvents()
        //{
        //    var listEvent = new List<Data.Event>();

        //    const string baseUri = "http://localhost:6268/api/GridEvents/";

        //    using (var httpClient = new HttpClient())
        //    {
        //        Task<String> response = httpClient.GetStringAsync(baseUri);
        //        listEvent = JsonConvert.DeserializeObjectAsync<List<Data.Event>>(response.Result).Result;
        //    }

        //    return PartialView(listEvent);
        //}

        public PartialViewResult EventDetails()
        {
            const string baseUri = "http://localhost:6268/api/EventDetails/";

            var eventDetail = new Data.Event();

            using (var httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(baseUri);
                eventDetail = JsonConvert.DeserializeObjectAsync<Data.Event>(response.Result).Result;
            }

            return PartialView(eventDetail);
        }
    }
}
