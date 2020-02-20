using System;

namespace Finance.Core.Entities
{
    public class Transaction
    {
        public int TranId { get; set; }
        public string Name { get; set; }
        public TranType TranType { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecurring { get; set; }
        public int ContactId { get; set; }
        public int TranRecId { get; set; }
    }
}
