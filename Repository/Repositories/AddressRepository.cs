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
    public class AddressRepository : BaseRepository
    {
        private SqlConnection conn;
        public AddressRepository()
        {
            conn = base.GetSqlConnection();
        }

        public AddressEntity GetAddress(int id)
        {
            var address = conn.Query<AddressEntity>("sp_GetAddress", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure)
            .FirstOrDefault();

            return address;
        }

        public AddressEntity SaveAddress(AddressEntity address)
        {
            var id = conn.ExecuteScalar("sp_CreateAddress", 
                new
                {
                    Street = address.Street,
                    Zipcode = address.Zipcode,
                    City = address.City,
                    State = address.State
                }, commandType: System.Data.CommandType.StoredProcedure);
            address.AddressId = (int)id;

            return address;
        }
    }
}
