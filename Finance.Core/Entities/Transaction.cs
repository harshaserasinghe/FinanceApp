using System;
using System.Xml.Serialization;

namespace Finance.Core.Entities
{
    public class Transaction
    {
        public Transaction()
        {
            IsActive = true;
        }
        public int TranId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TranType TranType { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecurring { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public int? TranRecId { get; set; }

        [XmlIgnore]
        public Contact Contact { get; set; }

        [XmlIgnore]
        public RecurringTransaction RecurringTransaction { get; set; }

        [XmlIgnore]
        public User User { get; set; }
    }
}
