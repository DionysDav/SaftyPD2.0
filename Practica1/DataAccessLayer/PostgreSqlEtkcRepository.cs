using System;
using System.Linq;
using Practica1.Domains;
using Practica1.Models;
using Practica1.Security;

namespace Practica1.DataAccessLayer
{
    public class PostgreSqlEtkcRepository
    {
        private ApplicationDbETKCContext _context = new ApplicationDbETKCContext();

        public IQueryable<Applicant> Applicants => _context.Applicants;


        public void AddApplicant(Request request)
        {
            string PD = request.ApplicantName + " " + request.PhoneNumber + " " + request.Email;
            var hash = new Sha256();
            string HashPD = hash.ComputeSha256Hash(PD);

            var applicant = new Applicant()
            {
                UserIdent = HashPD,
                PlanVisitDate = request.PlanVisitDate,
                PersonCountInGroup = request.PersonCountInGroup,
                IsConsentedForProcessingOfPD = request.IsConsentedForProcessingOfPD,
                EventId = request.EventId,
                TimeReques = DateTime.Now
            };
            
            _context.Add(applicant);
            _context.SaveChanges();
        }

        public void DelAplicant(Applicant applicant)
        {
            _context.Remove(applicant);
            _context.SaveChanges();
        }
    }
}