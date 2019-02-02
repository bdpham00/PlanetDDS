﻿using Dapper;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class VisitRepository : BaseRepository
    {
        private SqlConnection conn;
        public VisitRepository()
        {
            conn = base.GetSqlConnection();
        }

        public VisitEntity GetVisit(int id)
        {
            var address = conn.Query<VisitEntity>("sp_GetVisit", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure)
            .FirstOrDefault();

            return address;
        }

        public VisitEntity SaveVisit(VisitEntity visit)
        {
            var id = conn.ExecuteScalar("sp_CreateVisit", 
                new
                {
                    visit.PatientId, 
                    visit.DentistId,
                    visit.VisitDate,
                    visit.InsurancePolicyNumber,
                    visit.InsuranceCompany,
                    visit.InsuranceAddressId,
                    visit.TotalCost,
                    visit.PaidAmount,
                    visit.Balance
                }, 
                commandType: System.Data.CommandType.StoredProcedure);

            visit.PatientId = (int)id;

            return visit;
        }
    }
}
