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
        public string InsurancePolicyNumber { get; set; }
        public string InsuranceCompany { get; set; }
        public decimal TotalCost { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance { get; set; }
        public Patient Patient { get; set; }
        public Dentist Dentist { get; set; }
        public Address Address { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
