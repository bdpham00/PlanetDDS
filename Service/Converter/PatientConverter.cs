using Repository.Entities;
using Repository.Repositories;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Converter
{
    public class PatientConverter
    {
        private PatientRepository _repo;

        public PatientConverter()
        {
            _repo = new PatientRepository();
        }

        //public PatientEntity Convert(Patient source)
        //{
        //    PatientEntity destination = _repo.GetPatient(source.Id);

        //    if (destination == null)
        //        return new PatientEntity();

        //    destination.ContactId = source.Contact.Id;
        //    destination.PatientId = source.Id;

        //    return destination;
        //}

        //public Patient Convert(PatientEntity source)
        //{
        //    Patient destination = new Patient
        //    {
        //        Id = source.PatientId,
        //        Contact = new Contact
        //        {
        //            Id = source.ContactId
        //        }
        //    };

        //    return destination;
        //}
    }
}
