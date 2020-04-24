using System;

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
        public EvntType EvntType { get; set; }
        public string Description { get; set; }
        public DateTime EvntStartDate { get; set; }
        public DateTime EvntStartTime { get; set; }
        public DateTime EvntEndDate { get; set; }
        public DateTime EvntEndTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecurring { get; set; }
        public int UserId { get; set; }
        public int? EventRecId { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public RecurringEvent RecurringEvent { get; set; }
        public User User { get; set; }
    }
}
