using Finance.Core.Entities;

namespace Finance.Core.DTOs
{
    public class RecurringEventDto
    {
        public int EvntRecId { get; set; }
        public Frequency Frequency { get; set; }
        public Event Event { get; set; }
    }
}
