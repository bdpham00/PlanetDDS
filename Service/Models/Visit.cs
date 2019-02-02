using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public Dentist Dentist { get; set; }
        public AddressEntity Address { get; set; }
    }
}
