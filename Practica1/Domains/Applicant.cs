using System;

namespace Practica1.Domains
{
    public class Applicant
    {
        public int Id { get; set; }
        public string UserIdent { get; set; }
        public DateTime PlanVisitDate { get; set; } //дата
        public string PlanVisitTime { get; set; } //11.00 / 13.00
        public int? PersonCountInGroup { get; set; } // кол-во
        public bool IsConsentedForProcessingOfPD { get; set; } // галка
        public long? EventId { get; set; } //мероприятия
        public DateTime TimeReques { get; set; }
    }
}