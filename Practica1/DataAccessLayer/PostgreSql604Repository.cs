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
            string ConnectionString = "Server=192.168.88.3;Port=5432;User Id=foretkc;Password=123ewq;Database=db604;";
            connection = new NpgsqlConnection(ConnectionString);
        }

        public void AddApplicant(Request request)
        {
            connection.Open();

            string sql = 
                "INSERT INTO requests (ApplicantName, PhoneNumber, Email, PlanVisitDate, PlanVisitTime, PersonCountInGroup, IsConsentedForProcessingOfPD, EventId) VALUES ";
            sql += "(@b, @c, @d, @f, @g, @h, @k, @l)";

            NpgsqlCommand insert = new NpgsqlCommand(sql, connection);
            
            //insert.Parameters.Add("a", NpgsqlDbType.Integer);
            insert.Parameters.Add("b", NpgsqlDbType.Text);
            insert.Parameters.Add("c", NpgsqlDbType.Text);
            insert.Parameters.Add("d", NpgsqlDbType.Text);
            insert.Parameters.Add("f", NpgsqlDbType.Timestamp);
            insert.Parameters.Add("g", NpgsqlDbType.Text);
            insert.Parameters.Add("h", NpgsqlDbType.Integer);
            insert.Parameters.Add("k", NpgsqlDbType.Boolean);
            insert.Parameters.Add("l", NpgsqlDbType.Bigint);

            //insert.Parameters["a"].Value = request.Id;
            insert.Parameters["b"].Value = request.ApplicantName is null ? DBNull.Value : request.ApplicantName;
            insert.Parameters["c"].Value = request.PhoneNumber is null ? DBNull.Value : request.PhoneNumber;
            insert.Parameters["d"].Value = request.Email is null ? DBNull.Value : request.Email;
            insert.Parameters["f"].Value = request.PlanVisitDate;
            insert.Parameters["g"].Value = request.PlanVisitTime is null ? DBNull.Value : request.PlanVisitTime;
            insert.Parameters["h"].Value = request.PersonCountInGroup is null ? DBNull.Value : request.PersonCountInGroup;
            insert.Parameters["k"].Value = request.IsConsentedForProcessingOfPD;
            insert.Parameters["l"].Value = request.EventId is null ? DBNull.Value : request.EventId;
            
            insert.ExecuteNonQuery();
            connection.Close();
        }

    }
}