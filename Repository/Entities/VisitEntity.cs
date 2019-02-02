using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class VisitEntity
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public int DentistId { get; set; }
        public DateTime VisitDate { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string InsuranceCompany { get; set; }
        public int InsuranceAddressId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
