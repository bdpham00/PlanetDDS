using Service.Converter;
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
    public class DentistController : ApiController
    {
        // GET api/dentist/5
        public IHttpActionResult Get(int id)
        {
            DentistService service = new DentistService();
            ContactService contactService = new ContactService();

            var dentist = service.GetDentist(id);
            dentist.Contact = contactService.GetContact(dentist.Contact.Id);

            return Ok(dentist);
        }

        // POST api/dentist
        public IHttpActionResult Post([FromBody]Dentist dentist)
        {
            DentistService service = new DentistService();
            ContactService contactService = new ContactService();
            dentist.Contact = contactService.SaveContact(dentist.Contact);

            return Ok(service.SaveDentist(dentist));
        }
    }
}
