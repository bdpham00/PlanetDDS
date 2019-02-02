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
    public class DentistService
    {
        private DentistRepository _repo = new DentistRepository();
        private DentistConverter _converter = new DentistConverter();
        private ContactConverter _contactConverter = new ContactConverter();
        private AddressConverter _addressConverter = new AddressConverter();
        private ContactRepository _contactRepo = new ContactRepository();
        private AddressRepository _addressRepo = new AddressRepository();

        public DentistService()
        {
            _repo = new DentistRepository();
            _contactRepo = new ContactRepository();
            _addressRepo = new AddressRepository();
            _converter = new DentistConverter();
            _contactConverter = new ContactConverter();
            _addressConverter = new AddressConverter();
        }

        public Dentist GetDentist(int id)
        {
            var dentistEntity = _repo.GetDentist(id);
            var contactEntity = _contactRepo.GetContact(dentistEntity.ContactId);
            var addressEntity = _addressRepo.GetAddress(contactEntity.AddressId);

            var dentist = _converter.Convert(dentistEntity, contactEntity, addressEntity);

            return dentist; 
        }

        public Dentist SaveDentist(Dentist dentist)
        {
            var dentistEntity = _converter.Convert(dentist);
            var contactEntity = _contactConverter.Convert(dentist.Contact);
            var addressEntity = _addressConverter.Convert(dentist.Contact.Address);

            return _converter.Convert(_repo.SaveDentist(dentistEntity)
                    , _contactRepo.SaveContact(contactEntity)
                    , _addressRepo.SaveAddress(addressEntity)
            );
        }
    }
}
