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
    public class AddressConverter
    {
        private AddressRepository _repo;

        public AddressConverter()
        {
            _repo = new AddressRepository();
        }

        public AddressEntity Convert(Address source)
        {
            AddressEntity destination = _repo.GetAddress(source.Id);

            if (destination == null)
                return new AddressEntity
                {
                    Street = source.Street,
                    Zipcode = source.Zipcode,
                    City = source.City,
                    State = source.State
                };

            destination.AddressId = source.Id;

            return destination;
        }

        public Address Convert(AddressEntity source)
        {
            Address destination = new Address
            {
                Id = source.AddressId,
                City = source.City,
                State = source.State,
                Street = source.Street,
                Zipcode = source.Zipcode
            };

            return destination;
        }
    }
}
