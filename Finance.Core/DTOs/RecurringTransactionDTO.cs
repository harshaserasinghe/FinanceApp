using Finance.Core.Entities;

namespace Finance.Core.DTOs
{
    public class RecurringTransactionDto
    {
        public int TranRecId { get; set; }
        public Frequency Frequency { get; set; }
        public Transaction Transaction { get; set; }
    }
}
