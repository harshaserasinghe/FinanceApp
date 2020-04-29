using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class EventDto
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public TimeSpan EventStartTime { get; set; }
        public TimeSpan EventEndTime { get; set; }
        public bool IsRecurring { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int? EventRecId { get; set; }
        public Frequency? Frequency { get; set; }
    }
}
