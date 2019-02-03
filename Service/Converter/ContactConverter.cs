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
    public class ContactConverter
    {
        //private ContactRepository _repo;

        //public ContactConverter()
        //{
        //    _repo = new ContactRepository();
        //}

        //public ContactEntity Convert(Contact source)
        //{
        //    ContactEntity destination = _repo.GetContact(source.Id);

        //    if (destination == null)
        //        return new ContactEntity
        //        {
        //            FirstName = source.FirstName,
        //            LastName = source.LastName,
        //            AddressId = source.Address.Id
        //        };

        //    destination.ContactId = source.Id;

        //    return destination;
        //}

        //public Contact Convert(ContactEntity source)
        //{
        //    Contact destination = new Contact
        //    {
        //        Id = source.ContactId, 
        //        Address = new Address
        //        {
        //            Id = source.AddressId,

        //        },
        //        FirstName = source.FirstName,
        //        LastName = source.LastName
        //    };

        //    return destination;
        //}
    }
}
