using System;
using System.Xml.Serialization;

namespace Finance.Core.Entities
{
    public class Event
    {

        public Event()
        {
            IsActive = true;
        }
        public int EventId { get; set; }
        public string Name { get; set; }
        public EventType EventType { get; set; }
        public string Description { get; set; }
        public DateTime EventStartDate { get; set; }
        public TimeSpan EventStartTime { get; set; }
        public DateTime EventEndDate { get; set; }
        public TimeSpan EventEndTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecurring { get; set; }
        public int UserId { get; set; }
        public int? EventRecId { get; set; }
        public int? ContactId { get; set; }
        [XmlIgnore]
        public Contact Contact { get; set; }

        [XmlIgnore]
        public RecurringEvent RecurringEvent { get; set; }

        [XmlIgnore]
        public User User { get; set; }
    }
}
