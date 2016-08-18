using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using TradeMeSample.Models;

namespace TradeMeSample.Controllers.api
{
    public class ListingsController : ApiController
    {
        private static readonly ListingViewModel[] Listings =
        {
                new ListingViewModel { id = 1, name = "My Ferrari", StartDate = DateTime.Now, Featured = false, Price = 50000 },
                new ListingViewModel { id = 2, name = "My House", StartDate = DateTime.Now, Featured = true, Price = 500000 }
        };

        protected void Application_Start()
        {

        }

        // GET: api/Listings
        public IEnumerable<ListingViewModel> Get()
        {
            return Listings;
        }

        // GET: api/Listings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Listings
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Listings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Listings/5
        public void Delete(int id)
        {
        }
    }

}
