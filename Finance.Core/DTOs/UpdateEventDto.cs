using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class UpdateEventDto
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EventType EvntType { get; set; }
        public DateTime EvntStartDate { get; set; }
        public DateTime EvntEndDate { get; set; }
        public DateTime EvntStartTime { get; set; }
        public DateTime EvntEndTime { get; set; }
        public int ContactId { get; set; }
        public bool IsRecurring { get; set; }
        public int? EvntRecId { get; set; }
        public Frequency Frequency { get; set; }
        public int UserId { get; set; }
    }
}
