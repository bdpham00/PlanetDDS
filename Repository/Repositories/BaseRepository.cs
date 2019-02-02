using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Repository.Entities;

namespace Repository.Repositories
{
    public class BaseRepository
    {
        private const string CONSTRING = @"Server=tcp:planetdds.database.windows.net,1433;Initial Catalog=PlanetDDSSystem;Persist Security Info=False;User ID=baopham;Password=Testpassword123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public BaseRepository()
        {

        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(CONSTRING);
        }
    }
}
