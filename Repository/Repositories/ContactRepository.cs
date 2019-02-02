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
    public class ContactRepository : BaseRepository
    {
        private SqlConnection conn;
        public ContactRepository()
        {
            conn = base.GetSqlConnection();
        }

        public ContactEntity GetContact(int id)
        {
            var contact = conn.Query<ContactEntity>("sp_GetContact", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure)
            .FirstOrDefault();

            return contact;
        }

        public ContactEntity SaveContact(ContactEntity contact)
        {
            var id = conn.ExecuteScalar("sp_CreateContact", 
                new
                {
                    FirstName = contact.FirstName,
                    LastName = contact.LastName, 
                    AddressId = contact.AddressId
                }, commandType: System.Data.CommandType.StoredProcedure);
            contact.ContactId = (int)id;

            return contact;
        }
    }
}
