using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Dentist
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }
    }
}
