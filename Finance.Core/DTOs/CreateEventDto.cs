using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class CreateEventDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public TimeSpan EventStartTime { get; set; }
        public TimeSpan EventEndTime { get; set; }
        public int? ContactId { get; set; }
        public bool IsRecurring { get; set; }
        public Frequency Frequency { get; set; }
        public int UserId { get; set; }
    }
}
