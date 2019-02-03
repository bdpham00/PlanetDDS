using Dapper;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PatientRepository : BaseRepository
    {
        private SqlConnection conn;
        public PatientRepository()
        {
            conn = base.GetSqlConnection();
        }

        public PatientEntity GetPatient(int id)
        {
            var patient = conn.Query<PatientEntity>("sp_GetPatient", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure)
            .FirstOrDefault();

            return patient;
        }

        //public PatientEntity SavePatient(PatientEntity patient)
        //{
        //    var id = conn.ExecuteScalar("sp_CreatePatient", new { ContactId = patient.ContactId }, commandType: System.Data.CommandType.StoredProcedure);
        //    return GetPatient((int)id);
        //}
    }
}
