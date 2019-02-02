using Repository.Repositories;
using Service.Converter;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ContactService
    {
        private ContactRepository _repo;
        private ContactConverter _contactConverter;
        private AddressRepository _addressRepository;
        private AddressConverter _addressConverter;

        public ContactService()
        {
            _repo = new ContactRepository();
            _contactConverter = new ContactConverter();
            _addressRepository = new AddressRepository();
            _addressConverter = new AddressConverter();
        }

        public Contact GetContact(int id)
        {
            var contactEntity = _repo.GetContact(id);
            var contact = _contactConverter.Convert(contactEntity);
            contact.Address = _addressConverter.Convert(_addressRepository.GetAddress(contact.Address.Id));

            return contact;
        }

        public Contact SaveContact(Contact contact)
        {
            var addressEntity = _addressRepository.SaveAddress(_addressConverter.Convert(contact.Address));
            contact.Address = _addressConverter.Convert(addressEntity);
            var contactEntity = _repo.SaveContact(_contactConverter.Convert(contact));

            return _contactConverter.Convert(contactEntity);
        }
    }
}
