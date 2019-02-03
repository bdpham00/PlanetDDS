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
    public class DentistRepository : BaseRepository
    {
        private SqlConnection conn;
        public DentistRepository()
        {
            conn = base.GetSqlConnection();
        }

        public DentistEntity GetDentist(int id)
        {
            var dentist = conn.Query<DentistEntity>("sp_GetDentist", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure)
            .FirstOrDefault();

            return dentist;
        }

        //public DentistEntity SaveDentist(DentistEntity dentist)
        //{
        //    var id = conn.ExecuteScalar("sp_CreateDentist", new { dentist.FirstName, dentist.LastName, dentist.AddressId,  }, commandType: System.Data.CommandType.StoredProcedure);
        //    return GetDentist((int)id);
        //}
    }
}
