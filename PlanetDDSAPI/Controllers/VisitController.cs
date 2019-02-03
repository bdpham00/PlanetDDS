using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanetDDSAPI.Controllers
{
    public class VisitController : ApiController
    {
        // GET api/vi/sit5
        public IHttpActionResult Get(int id)
        {
            VisitService service = new VisitService();

            var visit = service.GetVisit(id);

            return Ok(visit);
        }

        // POST api/visit
        public IHttpActionResult Post([FromBody]Visit visit)
        {
            VisitService service = new VisitService();

            return Ok(service.SaveVisit(visit));
        }
    }
}
