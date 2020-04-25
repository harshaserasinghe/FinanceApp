using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class UpdateEventDto
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public int ContactId { get; set; }
        public bool IsRecurring { get; set; }
        public int? EventRecId { get; set; }
        public Frequency Frequency { get; set; }
        public int UserId { get; set; }
    }
}
