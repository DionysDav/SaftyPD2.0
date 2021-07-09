using System;
using System.Data.SqlClient;
using System.Text;
using Azure.Core;
using Practica1.Models;
using Request = Practica1.Models.Request;

namespace Practica1.DataAccessLayer
{
    public class PostgreSql604RepositoryOldToo
    {
        public SqlConnectionStringBuilder builder;
        public SqlConnection connection;

        public PostgreSql604RepositoryOldToo()
        {
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = "tcp:192.168.88.3, 5432"; 
            builder.UserID = "foretkc";            
            builder.Password = "123ewq";     
            builder.InitialCatalog = "db604";

            connection = new SqlConnection(builder.ConnectionString);
        }

        public void AddApplicant(Request request)
        {
            string sql =
                "INSERT INTO Request (Id, ApplicantName, PhoneNumber, Email, PlanVisitDate, PlanVisitTime, PersonCountInGroup, IsConsentedForProcessingOfPD, EventId) values (" +
                request.Id + ", " + request.ApplicantName + ", " + request.PhoneNumber + ", " + request.Email + ", " +
                request.PlanVisitDate + ", " + request.PlanVisitTime + ", " + request.PersonCountInGroup + ", " +
                request.IsConsentedForProcessingOfPD + ", " + request.EventId + ")";

            SqlCommand command = new SqlCommand(sql, connection);
            
            command.ExecuteNonQuery();
        }
    }
}