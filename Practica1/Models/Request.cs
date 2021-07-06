using System;
using System.ComponentModel.DataAnnotations;

namespace Practica1.Models
{
    public class Request
    {
        public string ApplicantName { get; set; } //фио
        public string PhoneNumber { get; set; } // тел
        public string Email { get; set; } //почта
        
        [DataType(DataType.Date)]
        public DateTime PlanVisitDate { get; set; } //дата
        public string PlanVisitTime { get; set; } //11.00 / 13.00
        public int PersonCountInGroup { get; set; } // кол-во
        public bool IsConsentedForProcessingOfPD { get; set; } // галка
        public long EventId { get; set; } //мероприятия
    }
}