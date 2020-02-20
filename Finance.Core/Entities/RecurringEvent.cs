namespace Finance.Core.Entities
{
    public class RecurringEvent
    {
        public int EventRecId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Frequency Frequency { get; set; }
    }
}
