using System;

namespace Finance.Core.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecurring { get; set; }
        public int? EventRecId { get; set; }

        public RecurringEvent RecurringEvent { get; set; }
    }
}
