using System;
using System.Data;
using Npgsql;
using System.Text;
using NpgsqlTypes;
using Practica1.Models;
using Request = Practica1.Models.Request;

namespace Practica1.DataAccessLayer
{
    public class PostgreSql604Repository
    {
        private NpgsqlConnection connection;

        public PostgreSql604Repository()
        {
            //SET YOUR VALUES HERE (CHANGE HOST AND PORT)
            string ConnectionString = "Server=192.168.88.3;Port=5432;User Id=foretkc;Password=123ewq;Database=db604;";
            connection = new NpgsqlConnection(ConnectionString);
        }

        public void AddApplicant(Request request)
        {
            connection.Open();

            string sql = 
                "INSERT INTO requests (ApplicantName, PhoneNumber, Email, PlanVisitDate, PlanVisitTime, PersonCountInGroup, IsConsentedForProcessingOfPD, EventId) VALUES ";
            sql += "(@a, @b, @c, @d, @e, @f, @g, @h)";

            NpgsqlCommand insert = new NpgsqlCommand(sql, connection);
            
            insert.Parameters.Add("a", NpgsqlDbType.Text);
            insert.Parameters.Add("b", NpgsqlDbType.Text);
            insert.Parameters.Add("c", NpgsqlDbType.Text);
            insert.Parameters.Add("d", NpgsqlDbType.Timestamp);
            insert.Parameters.Add("e", NpgsqlDbType.Text);
            insert.Parameters.Add("f", NpgsqlDbType.Integer);
            insert.Parameters.Add("g", NpgsqlDbType.Boolean);
            insert.Parameters.Add("h", NpgsqlDbType.Bigint);
            
            insert.Parameters["a"].Value = request.ApplicantName is null ? DBNull.Value : request.ApplicantName;
            insert.Parameters["b"].Value = request.PhoneNumber is null ? DBNull.Value : request.PhoneNumber;
            insert.Parameters["c"].Value = request.Email is null ? DBNull.Value : request.Email;
            insert.Parameters["d"].Value = request.PlanVisitDate;
            insert.Parameters["e"].Value = request.PlanVisitTime is null ? DBNull.Value : request.PlanVisitTime;
            insert.Parameters["f"].Value = request.PersonCountInGroup is null ? DBNull.Value : request.PersonCountInGroup;
            insert.Parameters["g"].Value = request.IsConsentedForProcessingOfPD;
            insert.Parameters["h"].Value = request.EventId is null ? DBNull.Value : request.EventId;
            
            insert.ExecuteNonQuery();
            connection.Close();
        }

    }
}