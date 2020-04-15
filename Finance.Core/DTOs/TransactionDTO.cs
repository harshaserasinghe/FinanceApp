using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class TransactionDto
    {
        public int TranId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TranType TranType { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsRecurring { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int? TranRecId { get; set; }
        public Frequency? Frequency { get; set; }
    }
}
