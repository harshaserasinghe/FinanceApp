using System.Collections.Generic;

namespace Finance.Core.Entities
{
    public class RecurringEvent
    {
        public RecurringEvent()
        {
            Events = new HashSet<Event>();
        }
        public int EventRecId { get; set; }
        public bool IsActive { get; set; }
        public Frequency Frequency { get; set; }

        public ICollection<Event> Events { get; private set; }
    }
}
