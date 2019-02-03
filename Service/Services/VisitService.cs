using Repository.Entities;
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
    public class VisitService
    {
        private VisitRepository _repo;
        private PatientRepository _patientRepo;
        private DentistRepository _dentistRepo;
        private VisitConverter _converter;

        public VisitService()
        {
            _repo = new VisitRepository();
            _patientRepo = new PatientRepository();
            _dentistRepo = new DentistRepository();
            _converter = new VisitConverter();
        }

        public Visit GetVisit(int id)
        {
            VisitEntity visitEntity = _repo.GetVisit(id);
            PatientEntity patientEntity = _patientRepo.GetPatient(visitEntity.PatientId);
            DentistEntity dentistEntity = _dentistRepo.GetDentist(visitEntity.DentistId);

            Visit visit = _converter.Convert(visitEntity, dentistEntity, patientEntity);

            return visit;
        }

        public Visit SaveVisit(Visit visit)
        {
            VisitEntity visitEntity = _repo.SaveVisit(_converter.Convert(visit));
            PatientEntity patientEntity = _patientRepo.GetPatient(visitEntity.PatientId);
            DentistEntity dentistEntity = _dentistRepo.GetDentist(visitEntity.DentistId);

            return _converter.Convert(visitEntity, dentistEntity, patientEntity);
        }
    }
}
