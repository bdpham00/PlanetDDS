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
    public class VisitConverter
    {
        private VisitRepository _repo;

        public VisitConverter()
        {
            _repo = new VisitRepository();
        }

        public VisitEntity Convert(Visit source)
        {
            VisitEntity destination = _repo.GetVisit(source.Id);

            if (destination == null)
                return new VisitEntity
                {
                    Balance = source.Balance,
                    DentistId = source.Dentist.Id,
                    InsuranceCompany = source.InsuranceCompany,
                    InsurancePolicyNumber = source.InsurancePolicyNumber,
                    PaidAmount = source.PaidAmount,
                    PatientId = source.Patient.Id,
                    TotalCost = source.TotalCost,
                    VisitDate = source.VisitDate,
                    VisitId = source.Id
                };

            return destination;
        }

        public Visit Convert(VisitEntity source, DentistEntity dentistSource, PatientEntity patientSource)
        {
            Visit destination = new Visit
            {
                Id = source.VisitId,
                Balance = source.Balance,
                Dentist = new Dentist
                {
                    Id = source.DentistId,
                    FirstName = dentistSource.FirstName,
                    LastName = dentistSource.LastName,
                    LicenseNumber = dentistSource.LicenseNumber,
                    AddressId = dentistSource.AddressId
                },
                InsuranceCompany = source.InsuranceCompany,
                InsurancePolicyNumber = source.InsurancePolicyNumber,
                PaidAmount = source.PaidAmount,
                Patient = new Patient
                {
                    Id = source.PatientId,
                    AddressId = patientSource.AddressId,
                    DateOfBirth = patientSource.DateOfBirth,
                    FirstName = patientSource.FirstName,
                    LastName = patientSource.LastName
                },
                TotalCost = source.TotalCost,
                VisitDate = source.VisitDate
            };

            return destination;
        }
    }
}
