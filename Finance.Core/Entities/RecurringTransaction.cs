namespace Finance.Core.Entities
{
    public class RecurringTransaction
    {
        public int TranRecId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Frequency Frequency { get; set; }
    }
}
