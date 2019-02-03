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
    public class DentistConverter
    {
        private DentistRepository _repo;

        public DentistConverter()
        {
            _repo = new DentistRepository();
        }

        //public DentistEntity Convert(Dentist source)
        //{
        //    DentistEntity destination = _repo.GetDentist(source.Id);

        //    if (destination == null)
        //        return new DentistEntity
        //        {
        //            ContactId = source.Contact.Id,
        //            DentistId = source.Id
        //        };

        //    destination.ContactId = source.Contact.Id;
        //    destination.DentistId = source.Id;

        //    return destination;
        //}

        //public Dentist Convert(DentistEntity source, ContactEntity contactSource, AddressEntity addressSource)
        //{
        //    Dentist destination = new Dentist
        //    {
        //        Id = source.DentistId,
        //        Contact = new Contact
        //        {
        //            Id = source.ContactId,
        //            FirstName = contactSource.FirstName,
        //            LastName = contactSource.LastName,
        //            Address = new Address
        //            {
        //                Id = contactSource.AddressId,
        //                City = addressSource.City,
        //                State = addressSource.State,
        //                Street = addressSource.Street,
        //                Zipcode = addressSource.Zipcode
        //            }
        //        }
        //    };

        //    return destination;
        //}
    }
}
